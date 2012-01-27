using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dbTurnos;
using dbTurnos.Excepciones;
using CheckIn_Turnos.Excepciones;

namespace CheckIn_Turnos
{
    public partial class TurnosForm : Form
    {
        public TurnosForm()
        {
            InitializeComponent();
            ActualizarHoraYTiempos();
            ActualizarTurnos();
        }

#region Funcionales (Sin manejo de excepciones)

        private void ActualizarHoraYTiempos()
        {
            hora_lbl.Text = DateTime.Now.ToShortTimeString();
            fecha_lbl.Text = DateTime.Now.ToLongDateString();
        }
        private void AbrirTurno()
        {
            Action abrirTurno = () =>
            {
                int id;
                DateTime entrada = DateTime.Now;
                try
                {
                    id = new IdentificacionForm("Abrir Turno").ShowDialog(this);
                    InterfazDb.AbrirTurno(id, entrada);
                    notificacion_lbl.Text = "Turno abierto para " + InterfazDb.UsuarioGetNombre(id) + " a las " + entrada.ToShortTimeString() + ".";
                    notificacion_pnl.Show();
                }
                catch (YaTieneTurnoAbiertoException ex)
                {
                    MessageBox.Show(ex.Message, "Turno Abierto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ActualizarTurnos();
            };
            ErrorHandlerForUserInterface.intentar(abrirTurno);
        }
        private void CerrarTurno(string usuario = "")
        {
            Action cerrarTurno = () =>
            {
                DateTime salida = DateTime.Now;
                IdentificacionForm idForm = new IdentificacionForm("Cerrar Turno");
                int id;
                if (usuario == "")
                    id = idForm.ShowDialog(this);
                else
                    id = idForm.ShowDialog(usuario, this);
                try
                {
                    InterfazDb.CerrarTurno(id, salida);
                    notificacion_lbl.Text = "Turno cerrado para " + InterfazDb.UsuarioGetNombre(id) + " a las " + salida.ToShortTimeString() + ".";
                    notificacion_pnl.Show();
                }
                catch (NoHayTurnoAbiertoException ex)
                {
                    MessageBox.Show(ex.Message, "Turno Abierto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (InicioTurnoMayorQueFinException ex)
                {
                    MessageBox.Show(ex.Message, "Turno Abierto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                ActualizarTurnos();
            };
            ErrorHandlerForUserInterface.intentar(cerrarTurno);
        }
        private void CambiarContraseña()
        {
            Action cambiarContraseña = () =>
            {
                new CambioContraseñaForm(new IdentificacionForm("Cambio de Contraseña").ShowDialog(this)).ShowDialog();
                notificacion_lbl.Text = "Contraseña cambiada correctamente.";
                notificacion_pnl.Show();
            };
            ErrorHandlerForUserInterface.intentar(cambiarContraseña);
        }
        private void ActualizarTurnos()
        {
            Action actualizarTurnos = () =>
            {
                turnos_lv.Items.Clear();
                foreach (DataRow turnoRow in InterfazDb.getTurnosAbiertos().Rows)
                {
                    ListViewItem lvi = new ListViewItem(turnoRow[1].ToString());
                    lvi.SubItems.Add(Convert.ToDateTime(turnoRow[2]).ToLongTimeString().ToString());
                    TimeSpan tiempoAbierto = DateTime.Now.Subtract(Convert.ToDateTime(turnoRow[2]));
                    lvi.SubItems.Add(string.Format("{0:D1} h {1:D2} m", tiempoAbierto.Hours, tiempoAbierto.Minutes));
                    turnos_lv.Items.Add(lvi);
                }
            };
            ErrorHandlerForUserInterface.intentar(actualizarTurnos);
            //HACK: esto no abre y ciera la conexion a la base de datos constatemente????
        }
       
#endregion

#region Comportamiento Interfaz (Con manejo de excepciones)
        private void administracion_cmd_Click(object sender, EventArgs e)
        {
            Action showAdminForm = () =>
            {
                try
                {
                    new AdministracionForm(new IdentificacionForm().ShowDialog(this)).ShowDialog(this);
                    ActualizarTurnos();
                }
                catch (NoTienePermisosRequeridosException)
                {
                    MessageBox.Show("Su usuario no tiene permisos para acceder a las funciones administrativas", "Administración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                }
            };
            ErrorHandlerForUserInterface.intentar(showAdminForm);
        }
        private void horaYTurnosAbiertos_tmr_Tick(object sender, EventArgs e)
        {
            ActualizarHoraYTiempos();
            notificacion_pnl.Hide();
            ActualizarTurnos();
        }
        private void turnos_lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = turnos_lv.HitTest(e.Location);
            if (hit.Item != null)
                CerrarTurno(hit.Item.Text);
        }
        private void NotificacionIma_lbl_Click(object sender, EventArgs e)
        {
            notificacion_pnl.Hide();
        }
        private void notificacion_lbl_Click(object sender, EventArgs e)
        {
            notificacion_pnl.Hide();
        }
        private void abrirTurno_cmd_Click(object sender, EventArgs e)
        {
            AbrirTurno();
        }
        private void CerrarTurno_cmd_Click(object sender, EventArgs e)
        {
            CerrarTurno();
        }
        private void contrasenia_cmd_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }
    }
#endregion
}
