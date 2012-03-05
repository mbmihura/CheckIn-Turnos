using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CheckIn_Turnos.Excepciones;
using dbTurnos;

namespace CheckIn_Turnos
{
    public partial class UsuarioEditarForm : UsuarioModificarForm
    {
        int _idUsuario;
        string _usuarioOriginal;
        bool _cambiaContraseña = false;

        public UsuarioEditarForm(int idUsuario)
        {
            _idUsuario = idUsuario;
            InitializeComponent();

            Action a = () =>
            {
                nombre_txt.Text = InterfazDb.UsuarioGetNombre(_idUsuario);
                _usuarioOriginal = InterfazDb.UsuarioGetUsuario(_idUsuario);
                usuario_txt.Text = _usuarioOriginal;
                cambioRequerido_chk.Checked = InterfazDb.UsuarioGetRequiereCambio(_idUsuario);
                habilitado_chk.Checked = InterfazDb.UsuarioGetHabilitado(_idUsuario);
                admin_chk.Checked = InterfazDb.UsuarioGetAdmin(_idUsuario);
            };
            ErrorHandlerForGUI.intentar(a);
        }

        private void guardar_cmd_Click(object sender, EventArgs e)
        {
            Action a = () =>
            {
                if ((!_cambiaContraseña || validarContraseña(true)) & (validarUsuario(true,_usuarioOriginal)) & validarNombre(true))
                {
                    if (!_cambiaContraseña)
                        InterfazDb.UsuarioEditar(_idUsuario, usuario_txt.Text, nombre_txt.Text, cambioRequerido_chk.Checked, habilitado_chk.Checked, admin_chk.Checked);
                    else
                        InterfazDb.UsuarioEditar(_idUsuario, usuario_txt.Text, nombre_txt.Text, contrasenia1_txt.Text, cambioRequerido_chk.Checked, habilitado_chk.Checked, admin_chk.Checked);
                    Close();
                }
                else 
                    MessageBox.Show("Los cambios realizados no se pueden guardar, revise los datos marcados en rojo.", "Falla Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            };
            ErrorHandlerForGUI.intentar(a);
        }
        private void mostrarCambiarContraseña(bool mostrar)
        {
            _cambiaContraseña = mostrar;
            cambiarContraseña_lnk.Visible = !mostrar;
            CancelarCambioContraseña_cmd.Visible = mostrar;
            repetirContraseña_lbl.Visible = mostrar;
            contrasenia1_txt.Visible = mostrar;
            contrasenia1_txt.Text = "";
            contrasenia2_txt.Visible = mostrar;
            contrasenia2_txt.Text = "";
            mostrarCaracteres_lnk.Visible = mostrar;
            contraseñaValidacion_lbl.Hide();
        }
        private void cambiarContraseña_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mostrarCambiarContraseña(true);
        }

        private void CancelarCambioContraseña_cmd_Click(object sender, EventArgs e)
        {
            mostrarCambiarContraseña(false);
        }

        private void usuario_txt_TextChanged(object sender, EventArgs e)
        {
            validarUsuario(false,_usuarioOriginal);
        }



        
    }
}
