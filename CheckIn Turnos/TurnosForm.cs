﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckIn_Turnos
{
    public partial class TurnosForm : Form
    {
        public TurnosForm()
        {
            InitializeComponent();
        }

        private void administracion_cmd_Click(object sender, EventArgs e)
        {
            //TODO: mostrar form adm.
            MessageBox.Show("No implementado todavia.");
        }
        private void contrasenia_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                new CambioContraseniaForm(new IdentificacionForm().ShowDialog(this)).ShowDialog();
            }
            catch (UsuarioCancelaException)
            { 
                //TODO: aviso
            }
        }
        private void abrirTurno_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: db adrir turno (idUsuario)
                //err. de turno ya abierto
                //error de base de datos, conexcion
            } catch ()
            {}
        }
        private void CerrarTurno_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: db cerrar turno (idUsuario)
                //err. de turno no abierto
                //error de base de datos, conexcion
            } catch ()
            {}
        }
    }
}
