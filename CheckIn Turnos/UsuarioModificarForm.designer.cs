namespace CheckIn_Turnos
{
    partial class UsuarioModificarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cancelar_cmd = new System.Windows.Forms.Button();
            this.guardar_cmd = new System.Windows.Forms.Button();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.contrasenia1_txt = new System.Windows.Forms.TextBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.accion_pic = new System.Windows.Forms.PictureBox();
            this.admin_chk = new System.Windows.Forms.CheckBox();
            this.habilitado_chk = new System.Windows.Forms.CheckBox();
            this.cambioRequerido_chk = new System.Windows.Forms.CheckBox();
            this.contrasenia2_txt = new System.Windows.Forms.TextBox();
            this.mostrarCaracteres_lnk = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.repetirContraseña_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contraseñaValidacion_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usuarioValidacion_lbl = new System.Windows.Forms.Label();
            this.nombreValidacion_lbl = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accion_pic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar_cmd
            // 
            this.cancelar_cmd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Accion_Eliminar;
            this.cancelar_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelar_cmd.Location = new System.Drawing.Point(12, 228);
            this.cancelar_cmd.Name = "cancelar_cmd";
            this.cancelar_cmd.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.cancelar_cmd.Size = new System.Drawing.Size(96, 30);
            this.cancelar_cmd.TabIndex = 9;
            this.cancelar_cmd.Text = "Cancelar";
            this.cancelar_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.cancelar_cmd, "Presione la tecla \'Esc\' para salir sin guardar.");
            this.cancelar_cmd.UseVisualStyleBackColor = true;
            this.cancelar_cmd.Click += new System.EventHandler(this.cancelar_cmd_Click);
            // 
            // guardar_cmd
            // 
            this.guardar_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Accion_Aceptar;
            this.guardar_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar_cmd.Location = new System.Drawing.Point(494, 228);
            this.guardar_cmd.Name = "guardar_cmd";
            this.guardar_cmd.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.guardar_cmd.Size = new System.Drawing.Size(91, 30);
            this.guardar_cmd.TabIndex = 8;
            this.guardar_cmd.Text = "Guardar";
            this.guardar_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.guardar_cmd, "Presione la tecla Enter para guardar y salir.");
            this.guardar_cmd.UseVisualStyleBackColor = true;
            // 
            // usuario_txt
            // 
            this.usuario_txt.Location = new System.Drawing.Point(77, 62);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(193, 20);
            this.usuario_txt.TabIndex = 2;
            this.toolTip.SetToolTip(this.usuario_txt, "Ingrese el usuario (Debe ser único en el sistema).");
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(77, 5);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 13);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Nombre:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contrasenia1_txt
            // 
            this.contrasenia1_txt.Location = new System.Drawing.Point(120, 19);
            this.contrasenia1_txt.Name = "contrasenia1_txt";
            this.contrasenia1_txt.Size = new System.Drawing.Size(126, 20);
            this.contrasenia1_txt.TabIndex = 3;
            this.toolTip.SetToolTip(this.contrasenia1_txt, "Ingrese una contaseña para que el usuario se identifique.");
            this.contrasenia1_txt.UseSystemPasswordChar = true;
            this.contrasenia1_txt.TextChanged += new System.EventHandler(this.contrasenia1_txt_TextChanged);
            // 
            // nombre_txt
            // 
            this.nombre_txt.BackColor = System.Drawing.SystemColors.Window;
            this.nombre_txt.Location = new System.Drawing.Point(77, 21);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(193, 20);
            this.nombre_txt.TabIndex = 1;
            this.toolTip.SetToolTip(this.nombre_txt, "Ingrese el nombre del usuario.");
            this.nombre_txt.TextChanged += new System.EventHandler(this.nombre_txt_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(77, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Usuario:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // accion_pic
            // 
            this.accion_pic.Location = new System.Drawing.Point(13, 12);
            this.accion_pic.Name = "accion_pic";
            this.accion_pic.Size = new System.Drawing.Size(48, 48);
            this.accion_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.accion_pic.TabIndex = 37;
            this.accion_pic.TabStop = false;
            // 
            // admin_chk
            // 
            this.admin_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.admin_chk.AutoSize = true;
            this.admin_chk.Location = new System.Drawing.Point(226, 187);
            this.admin_chk.Name = "admin_chk";
            this.admin_chk.Size = new System.Drawing.Size(103, 17);
            this.admin_chk.TabIndex = 7;
            this.admin_chk.Text = "Es administrador";
            this.toolTip.SetToolTip(this.admin_chk, "Habilita al usuario a usar las funciones administrativas.");
            this.admin_chk.UseVisualStyleBackColor = true;
            // 
            // habilitado_chk
            // 
            this.habilitado_chk.AutoSize = true;
            this.habilitado_chk.Checked = true;
            this.habilitado_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitado_chk.Location = new System.Drawing.Point(137, 187);
            this.habilitado_chk.Name = "habilitado_chk";
            this.habilitado_chk.Size = new System.Drawing.Size(73, 17);
            this.habilitado_chk.TabIndex = 6;
            this.habilitado_chk.Text = "Habilitado";
            this.toolTip.SetToolTip(this.habilitado_chk, "Habilita al usuario para que pueda usar el sistema.");
            this.habilitado_chk.UseVisualStyleBackColor = true;
            // 
            // cambioRequerido_chk
            // 
            this.cambioRequerido_chk.Location = new System.Drawing.Point(311, 14);
            this.cambioRequerido_chk.Name = "cambioRequerido_chk";
            this.cambioRequerido_chk.Size = new System.Drawing.Size(177, 31);
            this.cambioRequerido_chk.TabIndex = 5;
            this.cambioRequerido_chk.Text = "Requerir cambio de contraseña en el proximo uso";
            this.toolTip.SetToolTip(this.cambioRequerido_chk, "Obliga al usuario a tener que cambiar la contraseña por una diferente la próxima " +
                    "vez que use el sistema.");
            this.cambioRequerido_chk.UseVisualStyleBackColor = true;
            // 
            // contrasenia2_txt
            // 
            this.contrasenia2_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contrasenia2_txt.Location = new System.Drawing.Point(120, 45);
            this.contrasenia2_txt.Name = "contrasenia2_txt";
            this.contrasenia2_txt.Size = new System.Drawing.Size(126, 20);
            this.contrasenia2_txt.TabIndex = 4;
            this.toolTip.SetToolTip(this.contrasenia2_txt, "Repita la contraseña ingresada.");
            this.contrasenia2_txt.UseSystemPasswordChar = true;
            this.contrasenia2_txt.TextChanged += new System.EventHandler(this.contrasenia2_txt_TextChanged);
            // 
            // mostrarCaracteres_lnk
            // 
            this.mostrarCaracteres_lnk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrarCaracteres_lnk.AutoSize = true;
            this.mostrarCaracteres_lnk.Location = new System.Drawing.Point(252, 22);
            this.mostrarCaracteres_lnk.Name = "mostrarCaracteres_lnk";
            this.mostrarCaracteres_lnk.Size = new System.Drawing.Size(45, 13);
            this.mostrarCaracteres_lnk.TabIndex = 41;
            this.mostrarCaracteres_lnk.TabStop = true;
            this.mostrarCaracteres_lnk.Text = "Mostrar ";
            this.mostrarCaracteres_lnk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.mostrarCaracteres_lnk, "Haga click para mostrar la contraseña que ingresó.");
            this.mostrarCaracteres_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mostrarCaracteres_lnk_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Contraseña:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // repetirContraseña_lbl
            // 
            this.repetirContraseña_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repetirContraseña_lbl.AutoSize = true;
            this.repetirContraseña_lbl.Location = new System.Drawing.Point(6, 46);
            this.repetirContraseña_lbl.Name = "repetirContraseña_lbl";
            this.repetirContraseña_lbl.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.repetirContraseña_lbl.Size = new System.Drawing.Size(108, 16);
            this.repetirContraseña_lbl.TabIndex = 41;
            this.repetirContraseña_lbl.Text = "Repita la contraseña:";
            this.repetirContraseña_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contraseñaValidacion_lbl);
            this.groupBox1.Controls.Add(this.cambioRequerido_chk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mostrarCaracteres_lnk);
            this.groupBox1.Controls.Add(this.repetirContraseña_lbl);
            this.groupBox1.Controls.Add(this.contrasenia2_txt);
            this.groupBox1.Controls.Add(this.contrasenia1_txt);
            this.groupBox1.Location = new System.Drawing.Point(77, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 82);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contraseña";
            // 
            // contraseñaValidacion_lbl
            // 
            this.contraseñaValidacion_lbl.AutoSize = true;
            this.contraseñaValidacion_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.contraseñaValidacion_lbl.Location = new System.Drawing.Point(252, 48);
            this.contraseñaValidacion_lbl.Name = "contraseñaValidacion_lbl";
            this.contraseñaValidacion_lbl.Size = new System.Drawing.Size(152, 13);
            this.contraseñaValidacion_lbl.TabIndex = 50;
            this.contraseñaValidacion_lbl.Text = "Las contraseñas no coinciden.";
            this.contraseñaValidacion_lbl.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Permisos:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usuarioValidacion_lbl);
            this.panel1.Controls.Add(this.nombreValidacion_lbl);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.accion_pic);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.habilitado_chk);
            this.panel1.Controls.Add(this.nombre_txt);
            this.panel1.Controls.Add(this.admin_chk);
            this.panel1.Controls.Add(this.usuario_txt);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(579, 213);
            this.panel1.TabIndex = 48;
            // 
            // usuarioValidacion_lbl
            // 
            this.usuarioValidacion_lbl.AutoSize = true;
            this.usuarioValidacion_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.usuarioValidacion_lbl.Location = new System.Drawing.Point(276, 65);
            this.usuarioValidacion_lbl.Name = "usuarioValidacion_lbl";
            this.usuarioValidacion_lbl.Size = new System.Drawing.Size(161, 13);
            this.usuarioValidacion_lbl.TabIndex = 51;
            this.usuarioValidacion_lbl.Text = "El usuario ya existe, ingrese otro.";
            this.usuarioValidacion_lbl.Visible = false;
            // 
            // nombreValidacion_lbl
            // 
            this.nombreValidacion_lbl.AutoSize = true;
            this.nombreValidacion_lbl.BackColor = System.Drawing.Color.White;
            this.nombreValidacion_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nombreValidacion_lbl.Location = new System.Drawing.Point(276, 24);
            this.nombreValidacion_lbl.Name = "nombreValidacion_lbl";
            this.nombreValidacion_lbl.Size = new System.Drawing.Size(160, 13);
            this.nombreValidacion_lbl.TabIndex = 49;
            this.nombreValidacion_lbl.Text = "El nombre no puede estar vacio.";
            this.nombreValidacion_lbl.Visible = false;
            // 
            // UsuarioModificarForm
            // 
            this.AcceptButton = this.guardar_cmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar_cmd;
            this.ClientSize = new System.Drawing.Size(597, 265);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelar_cmd);
            this.Controls.Add(this.guardar_cmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioModificarForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "           ";
            ((System.ComponentModel.ISupportInitialize)(this.accion_pic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.TextBox contrasenia1_txt;
        protected internal System.Windows.Forms.TextBox contrasenia2_txt;
        protected internal System.Windows.Forms.LinkLabel mostrarCaracteres_lnk;
        protected internal System.Windows.Forms.Label repetirContraseña_lbl;
        protected System.Windows.Forms.Button cancelar_cmd;
        protected System.Windows.Forms.Button guardar_cmd;
        protected System.Windows.Forms.CheckBox cambioRequerido_chk;
        protected System.Windows.Forms.TextBox usuario_txt;
        protected System.Windows.Forms.Label Label3;
        protected System.Windows.Forms.TextBox nombre_txt;
        protected System.Windows.Forms.Label Label1;
        protected System.Windows.Forms.PictureBox accion_pic;
        protected System.Windows.Forms.CheckBox admin_chk;
        protected System.Windows.Forms.CheckBox habilitado_chk;
        protected internal System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Label contraseñaValidacion_lbl;
        protected System.Windows.Forms.Label usuarioValidacion_lbl;
        protected System.Windows.Forms.Label nombreValidacion_lbl;
        protected System.Windows.Forms.ToolTip toolTip;
    }
}