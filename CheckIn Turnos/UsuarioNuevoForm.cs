using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dbTurnos;
using dbTurnos.Excepciones;

namespace CheckIn_Turnos
{
    public partial class UsuarioNuevoForm : UsuarioModificarForm
    {
        public UsuarioNuevoForm()
        {
            InitializeComponent();
        }

        private void guardar_cmd_Click(object sender, EventArgs e)
        {
            if (validarContraseña(true) & validarUsuario(true) & validarNombre(true))
            {
                InterfazDb.UsuarioNuevo(usuario_txt.Text, nombre_txt.Text, contrasenia1_txt.Text, cambioRequerido_chk.Checked, habilitado_chk.Checked, admin_chk.Checked);
                Close();
            }
            else
                MessageBox.Show("El usuario no se puede crear, revise los datos marcados en rojo.", "Falla Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
