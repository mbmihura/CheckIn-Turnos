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
            
        private void abrirTurno_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                InterfazDb.AbrirTurno(new IdentificacionForm().ShowDialog(this), DateTime.Now);
            }
            catch (YaTieneTurnoAbiertoException ex)
            {
                MessageBox.Show(ex.Message, "Turno Abierto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (UsuarioCancelaException)
            {
                //no hacer nada: como el usuario cancelo, no devuele id de usuario por lo que no me interesa seguir con el flujo normal del CU
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                //TODO: invalidOperation exception no entra aca?
                MessageBox.Show("Ocurrió un problema con la Base de Datos. Probablemente se deba a que no se puedo abrir la conexion con la misma." + Environment.NewLine + Environment.NewLine + "Detalles del error:" + Environment.NewLine + ex.Message + "(" + ex.Source + ex.StackTrace + ")", "Error con la Base De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ocurrió un problema con la Base de Datos." + Environment.NewLine + Environment.NewLine + "Detalles del error:" + Environment.NewLine + ex.Message + "(" + ex.Source + ex.StackTrace + ")", "Error con la Base De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }
                catch (FormatException)
            {}
            catch (OverflowException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error que el programa no puede solucionar. La descripción del mismo es la siguiente:" + Environment.NewLine + ex.Message + Environment.NewLine + "Por " + ex.Source + ", en " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CerrarTurno_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                InterfazDb.CerrarTurno(new IdentificacionForm().ShowDialog(this), DateTime.Now);
                //TODO:manejar err. de turno no abierto
                //error de base de datos, conexcion
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void contrasenia_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                new CambioContraseniaForm(new IdentificacionForm().ShowDialog(this)).ShowDialog();
            }
            catch (UsuarioCancelaException ex)
            {
                MessageBox.Show(ex.Message);
                //TODO: aviso
            }
            catch (Exception ex)
            {
                //Par usuario.contraseña err.
                MessageBox.Show(ex.Message);
                //TODO: aviso
            }

        }
        private void administracion_cmd_Click(object sender, EventArgs e)
        {
            //TODO: manejar ex
            new AdministracionForm(new IdentificacionForm().ShowDialog(this)).ShowDialog(this);
            ////MessageBox.Show("Su usuario no tiene permisos para acceder a las funciones administrativas", "Administración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                

        }

        private void horaYTurnosAbiertos_tmr_Tick(object sender, EventArgs e)
        {
            ActualizarHoraYTiempos();
        }

        private void ActualizarHoraYTiempos()
        {
            hora_lbl.Text = DateTime.Now.ToShortTimeString();
            fecha_lbl.Text = DateTime.Now.ToLongDateString();
        }
        private void ActualizarTurnos()
        {
            //TODO: manejar err.
            //esto no abre y ciera la conexion a la base de datos constatemente????
            foreach (DataRow turnoRow in InterfazDb.getTurnosAbiertos().Rows)
            {
                ListViewItem lvi = new ListViewItem(turnoRow[1].ToString());
                lvi.SubItems.Add(Convert.ToDateTime(turnoRow[2]).ToLongTimeString().ToString());
                TimeSpan tiempoAbierto = Convert.ToDateTime(turnoRow[2]).Subtract(DateTime.Now);
                string diasAbierto = "";
                if (tiempoAbierto.TotalDays == 0)
                    diasAbierto = tiempoAbierto.TotalDays.ToString();
                lvi.SubItems.Add(tiempoAbierto.TotalHours % (tiempoAbierto.TotalDays*24) + ":" + tiempoAbierto.TotalMinutes % (tiempoAbierto.TotalHours*60));
                //turnos_lv.Items.Add(lvi);

                           }
            DataTable t = InterfazDb.getTurnosAbiertos();
            //TODO:estoy en el colectivo, averiguar como conectar ambos objetos
            turnos_lv.DataBindings.Add(turnos_lv.Columns[0].Name, t, t.Columns[0].ColumnName);

        }
    }
}
