using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheckIn_Turnos.Excepciones;
using dbTurnos.Excepciones;
using dbTurnos;

namespace CheckIn_Turnos
{
    public partial class CambioContraseñaForm : Form
    {
        protected bool _mostrandoContrasenia; //Determina el modo en el que se ingresa la contraseña
        protected int _idUsuario;
        private bool _cambioContraseña = false;
        private bool _contraseñaDebeDiferir = false;

        /// <summary>Crea un vista para cambiar la contraseña de un usuario.</summary><param name="usuario">Usuario al cual se le cambia la contraseña</param>
        public CambioContraseñaForm(int idUsuario)
        {
            _idUsuario = idUsuario;
            InitializeComponent();
        }

        public void ShowDialog(IWin32Window owner, bool contraseñaNuevaDebeDiferir = false)
        {
            _contraseñaDebeDiferir = contraseñaNuevaDebeDiferir;
            base.ShowDialog(owner);
            if (!_cambioContraseña)
                throw new UsuarioCancelaException();
        }

        public void ShowDialogRequerido(IWin32Window owner)
        {
            Height = 224;
            cambioRequerido_pnl.Show();
            cancelar_cmd.Enabled = false;
            ShowDialog(owner, true);

        }

        private void aceptar_cmd_Click(object sender, EventArgs e)
        {
            //Cuando no se muestra la contraseña, validad que coincian antes de cambiarla
            if (_mostrandoContrasenia || contrasenia1_txt.Text == contrasenia2_txt.Text) 
            {
                if (!_contraseñaDebeDiferir | contrasenia1_txt.Text != InterfazDb.UsuarioGetContraseña(_idUsuario))
                {
                    try
                    {
                        InterfazDb.CambiarContraseña(_idUsuario, contrasenia1_txt.Text);
                        _cambioContraseña = true;
                        this.Close();
                    }
                    catch (ContraseñaNoPuedeSerNula ex)
                    {
                        MessageBox.Show(ex.Message, "Falla Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    //informa err. y limpiar
                    MessageBox.Show("La nueva contraseña no puede ser igual a la actual, introduzca una diferente.", "Falla Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    contrasenia1_txt.Text = "";
                    contrasenia2_txt.Text = "";
                }
            }
            else 
            {
                //informa err. y limpiar
                MessageBox.Show("Las contraseñas no coinciden. Escribalas nuevamente.", "Falla Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                contrasenia1_txt.Text = "";
                contrasenia2_txt.Text = "";
            }
            contrasenia1_txt.Focus();
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


    }
}
