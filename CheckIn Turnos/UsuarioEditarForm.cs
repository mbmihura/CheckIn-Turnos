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

        public UsuarioEditarForm(int idUsuario)
        {
            _idUsuario = idUsuario;
            InitializeComponent();

            nombre_txt.Text=InterfazDb.UsuarioGetNombre(_idUsuario);
            usuario_txt.Text = InterfazDb.UsuarioGetUsuario(_idUsuario);
            cambioRequerido_chk.Checked = InterfazDb.UsuarioGetRequiereCambio(_idUsuario);
            habilitado_chk.Checked = InterfazDb.UsuarioGetHabilitado(_idUsuario);
            admin_chk.Checked = InterfazDb.UsuarioGetAdmin(_idUsuario);
        }

        private void guardar_cmd_Click(object sender, EventArgs e)
        {
                 if(validarContraseña(true) & validarUsuario(true) & validarNombre(true))
                {
                    if (contrasenia1_txt.Text == "")
                        InterfazDb.UsuarioEditar(_idUsuario, usuario_txt.Text, nombre_txt.Text, cambioRequerido_chk.Checked, habilitado_chk.Checked, admin_chk.Checked);
                    else
                        InterfazDb.UsuarioEditar(_idUsuario, usuario_txt.Text, nombre_txt.Text, contrasenia1_txt.Text, cambioRequerido_chk.Checked, habilitado_chk.Checked, admin_chk.Checked);
                    Close();
                }
                else 
                    MessageBox.Show("Los cambios realizados no se pueden guardar, revise los datos marcados en rojo.", "Falla Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void mostrarCambiarContraseña(bool mostrar)
        {
            cambiarContraseña_lnk.Visible = !mostrar;
            cancelar_cmd.Visible = mostrar;
            repetirContraseña_lbl.Visible = mostrar;
            contrasenia1_txt.Visible = mostrar;
            contrasenia1_txt.Text = "";
            contrasenia2_txt.Visible = mostrar;
            contrasenia2_txt.Text = "";
            mostrarCaracteres_lnk.Visible = mostrar;
            contraseñaValidacion_lbl.Visible = mostrar;
        }
        private void cambiarContraseña_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mostrarCambiarContraseña(true);
        }

        private void CancelarCambioContraseña_cmd_Click(object sender, EventArgs e)
        {
            mostrarCambiarContraseña(false);
        }

        
    }
}
