using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dbTurnos;
using CheckIn_Turnos.Excepciones;
using System.IO;
using System.Diagnostics;

namespace CheckIn_Turnos
{
    public partial class AdministracionForm : Form
    {
        public AdministracionForm(int idUsuario)
        {
            if (!InterfazDb.UsuarioGetAdmin(idUsuario)) throw new NoTienePermisosRequeridosException("Su usuario no tiene permisos para acceder a las funciones administrativas");
            InitializeComponent();
            Configuracion_lkl.Text = "Ubicación App: " + Application.StartupPath;
            usuario_dgv.DataSource = InterfazDb.UsuariosGetAll();
            usuario_dgv.Columns[0].Visible = false;
        }

        private void nuevo_cmd_Click(object sender, EventArgs e)
        {
            Action nuevoUsuario = () =>
           {
               new UsuarioNuevoForm().ShowDialog(this);
               ActualizarUsuariosDatagrid();
           };
            ErrorHandlerForGUI.intentar(nuevoUsuario);
        }

        private void modificar_cmd_Click(object sender, EventArgs e)
        {
            Action modificarUsuario = () =>
            {
                new UsuarioEditarForm(InterfazDb.UsuarioGetId(usuario_dgv.SelectedRows[0].Cells["usuario"].Value.ToString())).ShowDialog(this);
                ActualizarUsuariosDatagrid();
            };
            ErrorHandlerForGUI.intentar(modificarUsuario);
        }

        private void ActualizarUsuariosDatagrid()
        {
            usuario_dgv.DataSource = InterfazDb.UsuariosGetAll();
        }

        private void eliminar_cmd_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea eliminar a " + usuario_dgv.SelectedRows[0].Cells[2].Value + " del sistema? Toda la informacion respecto a sus turnos sera eliminada.", "Eliminar " + "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //HACK: validar que no se trate de elimnar el mismo
                Action EliminarUsuario = () =>
                {
                    InterfazDb.UsuarioEliminar(Convert.ToInt32(usuario_dgv.SelectedRows[0].Cells[0].Value));
                    ActualizarUsuariosDatagrid();
                };
                ErrorHandlerForGUI.intentar(EliminarUsuario);
            }
        }
        
        private void nombreODesde_checkedChangedOCambioDeTab(object sender, EventArgs e)
        {
            ActualizarTurnosDatagrid();
        }
        private void nombre_txt_TextChanged(object sender, EventArgs e)
        {
            ActualizarTurnosDatagrid();
        }
        private void fechaDesde_dtp_ValueChanged(object sender, EventArgs e)
        {
            //HACK: Validar que fecha desde no sea mayor a hasta
            desde_chk.Checked = true;
            ActualizarTurnosDatagrid();
        }

        private void fechaHasta_dtp_ValueChanged(object sender, EventArgs e)
        {
            //HACK: Validar que fecha hasta sea mayor a desde
            desde_chk.Checked = true;
            ActualizarTurnosDatagrid();
        }

        public void ActualizarTurnosDatagrid()
        {
            string _filtro = "WHERE (Usuarios.nombre LIKE '%" + nombre_txt.Text + "%')";
            if (desde_chk.Checked)
                _filtro += " AND (Turnos.fechaInicio BETWEEN #" + fechaDesde_dtp.Value.ToString("yyyy/MM/dd hh:mm:ss") + "# AND #" + fechaHasta_dtp.Value.ToString("yyyy/MM/dd hh:mm:ss") + "#)";
            Action cargarTurnos_dvg = () => { turnos_dgv.DataSource = InterfazDb.TurnosGetCumplen(_filtro); };
            ErrorHandlerForGUI.intentar(cargarTurnos_dvg);
        }

        private void exportar_cmd_Click(object sender, EventArgs e)
        {
            if (turnos_dgv.RowCount == 0)
            {
                string msj;
                if (nombre_txt.Text == "" && !desde_chk.Checked)
                    msj = "Todavia no se han registrados turnos en el sistema. No información que exportar";
                else
                    msj = "No hay ningún turno en la lista para que pueda ser exportado." + Environment.NewLine + "Cambie los datos usados en la busqueda.";
                MessageBox.Show(msj, "Exportar Turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (exportar_sfd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sbCSV = new StringBuilder();
                        int intColCount = turnos_dgv.ColumnCount;
                        foreach (DataGridViewRow dr in turnos_dgv.Rows)
                        {
                            for (int x = 0; x < intColCount; x++)
                            {
                                sbCSV.Append(dr.Cells[x].Value);
                                if ((x + 1) != intColCount)
                                {
                                    sbCSV.Append(",");
                                }
                            }
                            sbCSV.Append("\n");
                        }


                        StreamWriter objWriter = new StreamWriter(exportar_sfd.FileName, false);
                        objWriter.WriteLine(sbCSV.ToString());
                        objWriter.Close();
                    }
                    catch (Exception ex)
                    {
                        ErrorHandlerForGUI.TraceException(ex);
                        MessageBox.Show("No se pudo guardar el archivo csv. " + ex.Message,"Exportar Turnos",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        exportar_sfd.ShowDialog(this);
                    }
                }
            }
        }

        private void salir_cmd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Configuracion_lkl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Application.StartupPath);
        }




            }
}
