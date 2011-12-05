using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb ;
using System.IO;


namespace CheckIn_Turnos
{
    public partial class AdministracionController : Form
    {
        private int idUsuario;

        public AdministracionController()
        {
            
        }

        private void usuario_txt_TextChanged(object sender, EventArgs e)
        {
            nombre_chk.Checked = true;
            ActualizarTurnosDatagrid();
        }

        private void fechaDesde_dtp_ValueChanged(object sender, EventArgs e)
        {
            desde_chk.Checked = true;
            ActualizarTurnosDatagrid();
        }

        private void fechaHasta_dtp_ValueChanged(object sender, EventArgs e)
        {
            desde_chk.Checked = true;
            ActualizarTurnosDatagrid();
        }

        public void ActualizarTurnosDatagrid()
        {
            string _filtro = "WHERE ";
            if (nombre_chk.Checked)
                _filtro += "(Usuarios.nombre LIKE '%" + nombre_txt.Text + "%') AND ";
            if (desde_chk.Checked)
                _filtro += "(Turnos.fechaInicio BETWEEN #" + fechaDesde_dtp.Value.ToString("yyyy/MM/dd hh:mm:ss") + "# AND #" + fechaHasta_dtp.Value.ToString("yyyy/MM/dd hh:mm:ss") + "#) AND ";
            if (_filtro.Length > 8)
                _filtro = _filtro.Remove(_filtro.Length - 4, 4);
            else
                _filtro = "";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT Usuarios.nombre AS Nombre, Turnos.fechaInicio AS Inicio, Turnos.fechaFin AS Fin FROM (Turnos INNER JOIN Usuarios ON Turnos.Usuario = Usuarios.usuario) " + _filtro + "ORDER BY Turnos.fechaInicio", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Samsung7HP\\Desktop\\Dropbox\\Proyectos\\CheckInEmpleados\\Recursos\\bar.accdb");
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            turnos_dgv.DataSource = dataTable;
        }

        private void nombre_chk_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTurnosDatagrid();
        }
        
        private void desde_chk_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTurnosDatagrid();
        }

        private void nuevo_cmd_Click(object sender, EventArgs e)
        {
            new UsuarioNuevoController().ShowDialog(this);
            ActualizarUsuariosDatagrid();
        }

        private void modificar_cmd_Click(object sender, EventArgs e)
        {
            //usuario_dgv.DataSource = Usuario.
            //new UsuarioEditarController(usuario_dgv.DataSourceSelectedRows[0].Cells[0].Value.ToString()).ShowDialog(this);
            //ActualizarUsuariosDatagrid();
        }

        private void eliminar_cmd_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("¿Seguro que desea eliminar al " + "?. Todos sus turnos seran eliminados","Eliminar "+"",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                //TODO: Usuario.Eliminar (usuario_dgv.SelectedRows [0].Cells[0].Value )
                ActualizarUsuariosDatagrid();
            }
        }
        private void ActualizarUsuariosDatagrid()
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT nombre AS Nombre, usuario AS Usuario, esAdmin AS Administrador, estaHabilitado AS Habilitado, contraseña AS Contraseña FROM Usuarios ORDER BY nombre", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Samsung7HP\\Desktop\\Dropbox\\Proyectos\\CheckInEmpleados\\Recursos\\bar.accdb");
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            usuario_dgv.DataSource = dataTable;
        }

        private void tabla_tlp_Paint(object sender, PaintEventArgs e)
        {
            ActualizarTurnosDatagrid();
        }

        private void exportar_cmd_Click(object sender, EventArgs e)
        {
            string fName = "";
            saveFileDialog.Filter = "CSV files (*.csv)|*.CSV";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = saveFileDialog.FileName;
                if (File.Exists(fName))
                {if (DialogResult.Yes  == MessageBox.Show("El archivo ya existe. ¿Desea sobre escribirlo?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        EscribirArchivo(fName);
                }else
                    EscribirArchivo(fName);
            }
        }

        //                MessageBox.Show("Su usuario no tiene permisos para acceder a las funciones administrativas", "Administración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            
        private void EscribirArchivo(string fName)
        {
            StringBuilder sbCSV = new StringBuilder();
            int intColCount = turnos_dgv.ColumnCount;
            foreach (DataGridViewRow dr in turnos_dgv.Rows)
            {
                for (int x = 0; x < intColCount; x++)
                {
                    sbCSV.Append(dr.Cells[x].ToString());
                    if ((x + 1) != intColCount)
                    {
                        sbCSV.Append(",");
                    }
                }
                sbCSV.Append("\n");
            }

            try{

                StreamWriter objWriter = new StreamWriter(fName, false);

                objWriter.WriteLine(sbCSV.ToString() );


                objWriter.Close();

                }
            catch (Exception ex) {

                MessageBox.Show("Ocurrió un error al guargar el archivo csv: " + ex.ToString());
            }

        }

        private void AdministracionController_Load(object sender, EventArgs e)
        {
            //TODO: usuario_dgv.DataSource = ??;

        }
    }
}
