using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CheckIn_Turnos.Excepciones;

namespace CheckIn_Turnos
{
    public partial class UsuarioEditarController : UsuarioModificarForm
    {
        string _idUsuario;

        public UsuarioEditarController(string usuario)
        {
            _idUsuario = usuario;
            InitializeComponent();
            //TODO: traer datos de bd.
            try
            {
                //TODO: tipo_lbl.Text = ?? codigo + " (" + ?? tipo + ")";
            }
            catch (NoSePuedeMostrarContraseniaException)
            {
                mostrarCodigo_lnk.Hide();
            }

            //TODO: deteccion de admin y habilitado
            admin_chk.Checked = true;
            habilitado_chk.Checked = true;
        }

        private void guardar_cmd_Click(object sender, EventArgs e)
        {
            //HACK: segun diseño, no deberia ser un problema de performance. POO y abstraccion no afectaria ef rendimiento.
            try
            {
                //TODO: impactar db.
            }
            catch (NoPuedeSerVacioException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
