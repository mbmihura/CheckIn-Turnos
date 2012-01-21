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

namespace CheckIn_Turnos
{
    public partial class AdministracionForm : Form
    {
        public AdministracionForm(int idUsuario)
        {
            if (!InterfazDb.esAdmin(idUsuario)) throw new NoTienePermisosRequeridosException();
            InitializeComponent();
            usuario_dgv.DataSource = InterfazDb.getUsuarios();
            usuario_dgv.Columns[0].Visible = false;
        }

        private void nuevo_cmd_Click(object sender, EventArgs e)
        {
            //TODO:
            //new UsuarioNuevoController().ShowDialog(this);
            ActualizarUsuariosDatagrid();
        }

        private void modificar_cmd_Click(object sender, EventArgs e)
        {
            //TODO:
            //usuario_dgv.DataSource = Usuario.
            //new UsuarioEditarController(usuario_dgv.DataSourceSelectedRows[0].Cells[0].Value.ToString()).ShowDialog(this);
            //ActualizarUsuariosDatagrid();
        }

        private void ActualizarUsuariosDatagrid()
        {
            usuario_dgv.DataSource = InterfazDb.getUsuarios();
        }

        private void eliminar_cmd_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea eliminar a " + usuario_dgv.SelectedRows[0].Cells[2].Value + " del sistema? Toda la informacion respecto a sus turnos seran eliminados", "Eliminar " + "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //HACK: validar que no se trate de elimnar el mismo
                InterfazDb.UsuariosEliminar(Convert.ToInt32(usuario_dgv.SelectedRows[0].Cells[0].Value));
                ActualizarUsuariosDatagrid();
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
            //TODO: Validar que fecha desde no sea mayor a hasta
            desde_chk.Checked = true;
            ActualizarTurnosDatagrid();
        }

        private void fechaHasta_dtp_ValueChanged(object sender, EventArgs e)
        {
            //TODO: Validar que fecha hasta sea mayor a desde
            desde_chk.Checked = true;
            ActualizarTurnosDatagrid();
        }

        public void ActualizarTurnosDatagrid()
        {
            string _filtro = "WHERE (Usuarios.nombre LIKE '%" + nombre_txt.Text + "%')";
            if (desde_chk.Checked)
                _filtro += " AND (Turnos.fechaInicio BETWEEN #" + fechaDesde_dtp.Value.ToString("yyyy/MM/dd hh:mm:ss") + "# AND #" + fechaHasta_dtp.Value.ToString("yyyy/MM/dd hh:mm:ss") + "#)";
            turnos_dgv.DataSource = InterfazDb.getTurnosCumplen(_filtro);
        }

        private void exportar_cmd_Click(object sender, EventArgs e)
        {
            if (exportar_sfd.ShowDialog() == DialogResult.OK)
            {
                EscribirArchivo(exportar_sfd.FileName);
            }
        }
        private void EscribirArchivo(string fName)
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

            try
            {
                StreamWriter objWriter = new StreamWriter(fName, false);
                objWriter.WriteLine(sbCSV.ToString());
                objWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guargar el archivo csv: " + ex.ToString());
            }
        }
            }
}
