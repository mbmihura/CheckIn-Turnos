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
    public partial class Form1 : Form
    {
        public Form1(DataTable A)
        {
            InitializeComponent();
            dataGridView1.DataSource = A;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}