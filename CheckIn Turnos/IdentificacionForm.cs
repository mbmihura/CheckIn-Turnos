using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheckIn_Turnos.Excepciones;

namespace CheckIn_Turnos
{
    public partial class IdentificacionForm : Form
    {
        int _idUsuario = -1;
        private void ingresar_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Busca un el usuario con el par id/contraseña intorducidos.
                // err. conexcion db.
                this.Close();
            }
            catch (ParContraseniaUsuarioIncorrectoException) //TODO: Solo devuelve ParContraseniaUsuarioIncorrecto? errores de conexion con DB?
            {
                //informa err y limpia campos.
                MessageBox.Show("Usuario y/o contraseña incorrecto. Intente nuevamente.", "Identificación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usuario_txt.Text = "";
                usuario_txt.Focus();
                contrasenia_txt.Text = "";
            }
        }

        /// <summary>Muestra la pantalla de forma modal para que el usuario se identifique.</summary>
        /// <param name="owner">Formulario padre, que lo llama</param>
        /// <returns>Devuelve en usuario con el par id-contrasenia especifico.</returns>
        public new int ShowDialog(IWin32Window owner)
        {
            base.ShowDialog(owner);
            if (_idUsuario == -1)
                throw new UsuarioCancelaException();
            else
                return _idUsuario;
        }
    }
}
