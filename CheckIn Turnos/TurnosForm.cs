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
        static bool _actualizarTurnos = true;
        public TurnosForm()
        {
            InitializeComponent();
            ActualizarHoraYTiempos();
            ActualizarTurnos();
            
        }

        public static bool DetenerTimers { set {
            foreach TurnosForm tf in TurnosForm. 
                ;
                = !value; } }

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
                    notificacion_lbl.Text = "Turno abierto para " + InterfazDb.UsuarioGetNombre(id) + " a las " + entrada.ToShortTimeString();
                    notificacion_tmr.Interval = 5000;
                    notificacion_tmr.Start();
                    notificacion_pnl.Show();
                }
                catch (YaTieneTurnoAbiertoException ex)
                {
                    MessageBox.Show(ex.Message, "Turno Abierto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ActualizarTurnos();
            };
            ErrorHandlerForGUI.intentar(abrirTurno);
        }
        private void CerrarTurno(string nombre = "")
        {
            Action cerrarTurno = () =>
            {
                DateTime salida = DateTime.Now;
                IdentificacionForm idForm = new IdentificacionForm("Cerrar Turno");
                int id;
                if (nombre == "")
                    id = idForm.ShowDialog(this);
                else
                    id = idForm.ShowDialog(nombre, this);
                try
                {
                    InterfazDb.CerrarTurno(id, salida);
                    notificacion_lbl.Text = "Turno cerrado para " + InterfazDb.UsuarioGetNombre(id) + " a las " + salida.ToShortTimeString();
                    notificacion_tmr.Interval = 5000;
                    notificacion_tmr.Start();
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
            ErrorHandlerForGUI.intentar(cerrarTurno);
        }
        private void CambiarContraseña()
        {
            Action cambiarContraseña = () =>
            {
                int id = new IdentificacionForm("Cambio de Contraseña").ShowDialog(this, false);
                new CambioContraseñaForm(id).ShowDialog(this,InterfazDb.UsuarioGetRequiereCambio(id));
                InterfazDb.UsuarioSetRequiereCambio(id, false);
                notificacion_lbl.Text = "Contraseña cambiada correctamente.";
                notificacion_tmr.Interval = 5000;
                notificacion_tmr.Start();
                notificacion_pnl.Show();
            };
            ErrorHandlerForGUI.intentar(cambiarContraseña);
        }
        private void ActualizarTurnos()
        {
            Action actualizarTurnos = () =>
            {
                turnos_lv.Items.Clear();
                foreach (DataRow turnoRow in InterfazDb.TurnosGetAbiertos().Rows)
                {
                    ListViewItem lvi = new ListViewItem(turnoRow[1].ToString());
                    DateTime inicio = Convert.ToDateTime(turnoRow[2]);
                    TimeSpan tiempoAbierto = DateTime.Now.Subtract(inicio);
                    if (tiempoAbierto < new TimeSpan(1, 0, 0, 0))
                    {
                        lvi.SubItems.Add(inicio.ToLongTimeString());
                        lvi.SubItems.Add(string.Format("{0:D1} h {1:D2} m", tiempoAbierto.Hours, tiempoAbierto.Minutes));
                    }
                    else
                    {
                        lvi.SubItems.Add(inicio.ToShortDateString() + " " + inicio.ToShortTimeString());
                        lvi.SubItems.Add(string.Format("{0:D1} dias, {0:D1} h {1:D2} m",tiempoAbierto.Days, tiempoAbierto.Hours, tiempoAbierto.Minutes));
                    }
                    lvi.Tag = turnoRow[0].ToString();
                    turnos_lv.Items.Add(lvi);
                }
            };
            ErrorHandlerForGUI.intentar(actualizarTurnos);
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
                    new AdministracionForm(new IdentificacionForm("Administración").ShowDialog(this)).ShowDialog(this);
                    ActualizarTurnos();
                }
                catch (NoTienePermisosRequeridosException ex)
                {
                    MessageBox.Show(ex.Message, "Administración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                }
            };
            ErrorHandlerForGUI.intentar(showAdminForm);
        }

        private void notificacion_tmr_Tick(object sender, EventArgs e)
        {
            notificacion_tmr.Stop();
            notificacion_pnl.Hide();
        }
        private void horaYTurnosAbiertos_tmr_Tick(object sender, EventArgs e)
        {
            ActualizarHoraYTiempos();
            if (_actualizarTurnos)
                ActualizarTurnos();
        }
        private void turnos_lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = turnos_lv.HitTest(e.Location);
            if (hit.Item != null)
                CerrarTurno(hit.Item.Tag.ToString());
        }
        private void NotificacionIma_lbl_Click(object sender, EventArgs e)
        {
            notificacion_tmr.Stop();
            notificacion_pnl.Hide();
        }
        private void notificacion_lbl_Click(object sender, EventArgs e)
        {
            notificacion_tmr.Stop();
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
