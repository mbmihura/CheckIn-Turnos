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
    public partial class CambioContraseniaForm : Form
    {
        bool _mostrandoContrasenia; //Determina el modo en el que se ingresa la contraseña
        int _idUsusuario;

        /// <summary>Crea un vista para cambiar la contraseña de un usuario.</summary><param name="usuario">Usuario al cual se le cambia la contraseña</param>
        public CambioContraseniaForm(int idUsuario)
        {
            _idUsusuario = idUsuario;
        }

        private void aceptar_cmd_Click(object sender, EventArgs e)
        {
            //Cuando no se muestra la contraseña, validad que coincian antes de cambiarla
            if (_mostrandoContrasenia || contrasenia1_txt.Text == contrasenia2_txt.Text) 
            {
                try
                {
                    // impactar db con contrasenia1_txt.Text;
                    this.Close();
                }
                catch (NoPuedeSerVacioException ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                //informa err. y limpiar
                MessageBox.Show("Las contraseñas no coinciden. Escribalas nuevamente.", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contrasenia1_txt.Text = "";
                contrasenia2_txt.Text = "";
            }
        }

        //Alterna entre los modos mostrar contraseña y introducirla dos veces
        private void mostrar_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Cambia al modo contrario, y actualiza la vista para reflejar el cambio.
            _mostrandoContrasenia = !_mostrandoContrasenia;
            contrasenia1_txt.UseSystemPasswordChar = !_mostrandoContrasenia;
            contrasenia2_txt.Enabled = !_mostrandoContrasenia;
            if (_mostrandoContrasenia)
            {
                mostrar_lnk.Text = "Ocultar";
                contrasenia2_txt.Text = "";
            }
            else
            {
                mostrar_lnk.Text = "Mostrar";
                contrasenia2_txt.Text = contrasenia1_txt.Text;
            }
        }

        //Cerrar la vista, sin guardar
        private void cancelar_cmd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
