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
    //Clase abstracta, no se instancia nunca (No se define como tal por el editor grafico del VS2010)
    public partial class UsuarioModificarForm : Form
    {
        private bool _mostrandoContrasenia;
        private bool _mostrandoCodigo;
        protected string _contraseniaPrevia;

        public UsuarioModificarForm()
        {
            InitializeComponent();           
        }       

        //Salir de sin guardar
        private void cancelar_cmd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelarContraseña_cmd_Click(object sender, EventArgs e)
        {
            ingresoManual_pnl.Hide();
            contraseniaAnterior_flp.Show();
        }

        
        //Alterna entre los modos mostrar contraseña y introducirla dos veces
        private void mostrarCaracteres_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Cambia al modo contrario, y actualiza la vista para reflejar el cambio.
            _mostrandoContrasenia = !_mostrandoContrasenia;
            contrasenia1_txt.UseSystemPasswordChar = !_mostrandoContrasenia;
            contrasenia2_txt.Enabled = !_mostrandoContrasenia;

            if (_mostrandoContrasenia)
            {
                mostrarCaracteres_lnk.Text = "Ocultar";
                contrasenia2_txt.Text = "";
            }
            else
            {
                mostrarCaracteres_lnk.Text = "Mostrar";
                contrasenia2_txt.Text = contrasenia1_txt.Text;
            }
        }

        private void cambioModoIngresoContraseña_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contrasenia1_txt.Text = "";
            contrasenia2_txt.Text = "";
            ingresoManual_pnl.Show();
            contraseniaAnterior_flp.Hide();
        }

        private void mostrarCodigo_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _mostrandoCodigo = !_mostrandoCodigo;
            if (_mostrandoCodigo) {
            mostrarCodigo_lnk.Text = "Ocultar";   
            //TODO: tipo_lbl.Text =?? + " (" + ?? tipo + ")";
            } else {
                mostrarCodigo_lnk.Text = "Mostrar";   
            //TODO: tipo_lbl.Text = ??;
            }
        }

        /// <summary>Devuelve con que contraseña se debe guardar el usuario, si con la previa o si se selecciono una nueva.</summary>
        /// <returns>Contraseña Actual</returns>
        /// <exception cref="ContraseniaNoCoincidenException">Si las contraseñas son diferentes, se informa al usuario, y luego lanza un excepcion.</exception>
        protected string DeterminarContraseniaActual()
        {
            //Si contraseniaAnterior_flp esta visible, la contraseña no cambio. Si no, determinar una nueva contraseña y su SHA256 a partir del string introducido.
            if (contraseniaAnterior_flp.Visible)
            {
                return _contraseniaPrevia;
            }
            else 
            {
                //Cuando no se muestra la contraseña, validad que coincian antes de cambiarla
                if (_mostrandoContrasenia || contrasenia1_txt.Text == contrasenia2_txt.Text)
                {
                    //TODO: impactar DB.
                    return contrasenia1_txt.Text ;
                }
                else
                {
                    //informa err. y limpiar
                    MessageBox.Show("Las contraseñas no coinciden. Escribalas nuevamente.", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contrasenia1_txt.Text = "";
                    contrasenia2_txt.Text = "";
                    throw new ContraseniasNoCoincidenException();
                }
            }
        }
    }
}
