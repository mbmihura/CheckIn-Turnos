using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheckIn_Turnos.Excepciones;
using dbTurnos;
using dbTurnos.Excepciones;

namespace CheckIn_Turnos
{
    public partial class IdentificacionForm : Form
    {
        int _idUsuario = -1;

        public IdentificacionForm(string titulo)
        {
            InitializeComponent();
            Text = titulo + " - Identificacion de Usuario";
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        private void ingresar_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                _idUsuario = InterfazDb.Identificar(usuario_txt.Text, contrasenia_txt.Text);
                this.Close();
            }
            catch (ParUsuarioContraseñaIncorrectoException ex)
            {
                //informa err y limpia campos.
                MessageBox.Show(ex.Message + "Intente nuevamente.", "Identificación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usuario_txt.Focus();
                contrasenia_txt.Text = "";
            }
            catch (UsuarioSuspendidoException ex)
            {
                MessageBox.Show(ex.Message, "Identificación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        /// <summary>Muestra la pantalla de forma modal para que el usuario se identifique.</summary>
        /// <param name="owner">Formulario padre, que lo llama</param>
        /// <returns>Devuelve en usuario con el par id-contrasenia especifico.</returns>
        /// <exception cref="CheckIn_Turnos.Excepciones.UsuarioCancelaException"></exception>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        public int ShowDialog(IWin32Window owner, bool permitirRequerirCambio = true)
        {
            base.ShowDialog(owner);
            if (_idUsuario == -1)
                throw new UsuarioCancelaException();
            else
            {
                if (InterfazDb.UsuarioGetRequiereCambio(_idUsuario) && permitirRequerirCambio)
                {
                    new CambioContraseñaForm(_idUsuario).ShowDialogRequerido(owner);
                    InterfazDb.UsuarioSetRequiereCambio(_idUsuario, false);
                }
                return _idUsuario;
            }
        }

        public int ShowDialog(string usuarioDefault, IWin32Window owner, bool permitirRequerirCambio = true)
        {
            usuario_txt.Text = usuarioDefault;
            return ShowDialog(owner, permitirRequerirCambio);
        }
    }
}
