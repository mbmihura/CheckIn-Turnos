﻿using System;
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
    //Clase abstracta, no se instancia nunca (No se define como tal por el editor grafico del VS2010)
    public partial class UsuarioModificarForm : Form
    {
        private bool _mostrandoContrasenia;
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
            validarContraseña(false);
        }

        protected bool validarNombre(bool pintarFondo) 
        {
            if (nombre_txt.Text == "")
            {
                nombre_txt.Focus();
                nombreValidacion_lbl.Show();
                if (pintarFondo)
                    nombre_txt.BackColor = Color.FromArgb(250, 234, 234);
                return false;
            }
            nombreValidacion_lbl.Hide();
            nombre_txt.BackColor = SystemColors.Window;
            return true;
        }

        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.Data.OleDb.OleDbException"></exception>
        /// <exception cref="dbTurnos.Excepciones.NoExisteUsuarioException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        protected bool validarUsuario(bool pintarFondo, string usuarioOriginal = "") 
        {
            //TODO:
            // - MANEJO ERROR (no se realiza por que el metodo devuelve un bool, con la implementacion actual de 
            //ErrorHandler4GUI.intentar() no funciona. podria crearse otro metodo intenetarReturnBool() para esto pero repetiria mucho codigo de manejo
            //de error. investigar forma correcta, en facu no saben)
            // - en la teoria el rendimiento no se deberia ver afectado, pero vigilarlo.
            try
                {
                    if (usuario_txt.Text == "")
                    {
                        usuarioValidacion_lbl.Text = "El usuario no puede estar vacio.";
                    }
                    else if (usuario_txt.Text == usuarioOriginal)
                    {
                        throw new NoExisteUsuarioException();
                    }
                    else
                    {
                        InterfazDb.UsuarioGetId(usuario_txt.Text);
                        usuarioValidacion_lbl.Text = "El usuario introducido ya exise.";
                    }
                    usuarioValidacion_lbl.Show();
                    if (pintarFondo)
                        usuario_txt.BackColor = Color.FromArgb(250, 234, 234);
                    return false;
                }
                catch (NoExisteUsuarioException)
                {
                    usuarioValidacion_lbl.Hide();
                    usuario_txt.BackColor = SystemColors.Window;
                    return true;
                }
        }
        protected bool validarContraseña(bool pintarFondoYTab)
        {
            if ((_mostrandoContrasenia | contrasenia1_txt.Text == contrasenia2_txt.Text) && contrasenia1_txt.Text != "")
            {
                contraseñaValidacion_lbl.Hide();
                contrasenia1_txt.BackColor = SystemColors.Window;
                contrasenia2_txt.BackColor = contrasenia1_txt.BackColor;
                return true;
            }
            else
            {
                if (!_mostrandoContrasenia && contrasenia1_txt.Text != contrasenia2_txt.Text)
                    contraseñaValidacion_lbl.Text = "Las contraseñas no coinciden.";
                else
                    contraseñaValidacion_lbl.Text = "La contraseña no puede estar vacia.";
                contraseñaValidacion_lbl.Show();
                if (pintarFondoYTab)
                {
                    contrasenia1_txt.Focus();
                    contrasenia1_txt.BackColor = Color.FromArgb(250, 234, 234);
                    contrasenia2_txt.BackColor = contrasenia1_txt.BackColor;
                }
                return false;
            }
        }

        private void nombre_txt_TextChanged(object sender, EventArgs e)
        {
            validarNombre(false);
        }

        private void contrasenia2_txt_TextChanged(object sender, EventArgs e)
        {
            validarContraseña(false);
        }

        private void contrasenia1_txt_TextChanged(object sender, EventArgs e)
        {
                validarContraseña(false);
        }

    }
}
        