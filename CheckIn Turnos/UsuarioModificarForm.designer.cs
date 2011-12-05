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
            this.cancelarContraseña_cmd = new System.Windows.Forms.Button();
            this.mostrarCaracteres_lnk = new System.Windows.Forms.LinkLabel();
            this.ingresoManual_pnl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contraseniaAnterior_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tipo_lbl = new System.Windows.Forms.Label();
            this.mostrarCodigo_lnk = new System.Windows.Forms.LinkLabel();
            this.cambioModoIngresoContraseña_lnk = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accion_pic)).BeginInit();
            this.ingresoManual_pnl.SuspendLayout();
            this.contraseniaAnterior_flp.SuspendLayout();
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
            this.cancelar_cmd.TabIndex = 7;
            this.cancelar_cmd.Text = "Cancelar";
            this.cancelar_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.guardar_cmd.TabIndex = 6;
            this.guardar_cmd.Text = "Guardar";
            this.guardar_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar_cmd.UseVisualStyleBackColor = true;
            // 
            // usuario_txt
            // 
            this.usuario_txt.Location = new System.Drawing.Point(77, 62);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(193, 20);
            this.usuario_txt.TabIndex = 2;
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
            this.contrasenia1_txt.Location = new System.Drawing.Point(108, 3);
            this.contrasenia1_txt.Name = "contrasenia1_txt";
            this.contrasenia1_txt.Size = new System.Drawing.Size(126, 20);
            this.contrasenia1_txt.TabIndex = 3;
            this.contrasenia1_txt.UseSystemPasswordChar = true;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(77, 21);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(193, 20);
            this.nombre_txt.TabIndex = 1;
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
            this.admin_chk.Location = new System.Drawing.Point(137, 187);
            this.admin_chk.Name = "admin_chk";
            this.admin_chk.Size = new System.Drawing.Size(103, 17);
            this.admin_chk.TabIndex = 4;
            this.admin_chk.Text = "Es administrador";
            this.admin_chk.UseVisualStyleBackColor = true;
            // 
            // habilitado_chk
            // 
            this.habilitado_chk.AutoSize = true;
            this.habilitado_chk.Checked = true;
            this.habilitado_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitado_chk.Location = new System.Drawing.Point(291, 23);
            this.habilitado_chk.Name = "habilitado_chk";
            this.habilitado_chk.Size = new System.Drawing.Size(73, 17);
            this.habilitado_chk.TabIndex = 5;
            this.habilitado_chk.Text = "Habilitado";
            this.habilitado_chk.UseVisualStyleBackColor = true;
            // 
            // cambioRequerido_chk
            // 
            this.cambioRequerido_chk.Location = new System.Drawing.Point(12, 42);
            this.cambioRequerido_chk.Name = "cambioRequerido_chk";
            this.cambioRequerido_chk.Size = new System.Drawing.Size(231, 31);
            this.cambioRequerido_chk.TabIndex = 38;
            this.cambioRequerido_chk.Text = "Requerir cambio de contraseña en el proximo uso";
            this.cambioRequerido_chk.UseVisualStyleBackColor = true;
            // 
            // contrasenia2_txt
            // 
            this.contrasenia2_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contrasenia2_txt.Location = new System.Drawing.Point(349, 3);
            this.contrasenia2_txt.Name = "contrasenia2_txt";
            this.contrasenia2_txt.Size = new System.Drawing.Size(127, 20);
            this.contrasenia2_txt.TabIndex = 39;
            this.contrasenia2_txt.UseSystemPasswordChar = true;
            // 
            // cancelarContraseña_cmd
            // 
            this.cancelarContraseña_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarContraseña_cmd.Location = new System.Drawing.Point(416, 25);
            this.cancelarContraseña_cmd.Name = "cancelarContraseña_cmd";
            this.cancelarContraseña_cmd.Size = new System.Drawing.Size(60, 23);
            this.cancelarContraseña_cmd.TabIndex = 40;
            this.cancelarContraseña_cmd.Text = "Cancelar";
            this.cancelarContraseña_cmd.UseVisualStyleBackColor = true;
            this.cancelarContraseña_cmd.Click += new System.EventHandler(this.cancelarContraseña_cmd_Click);
            // 
            // mostrarCaracteres_lnk
            // 
            this.mostrarCaracteres_lnk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrarCaracteres_lnk.AutoSize = true;
            this.mostrarCaracteres_lnk.Location = new System.Drawing.Point(365, 30);
            this.mostrarCaracteres_lnk.Name = "mostrarCaracteres_lnk";
            this.mostrarCaracteres_lnk.Size = new System.Drawing.Size(45, 13);
            this.mostrarCaracteres_lnk.TabIndex = 41;
            this.mostrarCaracteres_lnk.TabStop = true;
            this.mostrarCaracteres_lnk.Text = "Mostrar ";
            this.mostrarCaracteres_lnk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mostrarCaracteres_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mostrarCaracteres_lnk_LinkClicked);
            // 
            // ingresoManual_pnl
            // 
            this.ingresoManual_pnl.Controls.Add(this.label5);
            this.ingresoManual_pnl.Controls.Add(this.mostrarCaracteres_lnk);
            this.ingresoManual_pnl.Controls.Add(this.label4);
            this.ingresoManual_pnl.Controls.Add(this.cancelarContraseña_cmd);
            this.ingresoManual_pnl.Controls.Add(this.contrasenia1_txt);
            this.ingresoManual_pnl.Controls.Add(this.contrasenia2_txt);
            this.ingresoManual_pnl.Location = new System.Drawing.Point(3, 13);
            this.ingresoManual_pnl.Name = "ingresoManual_pnl";
            this.ingresoManual_pnl.Size = new System.Drawing.Size(481, 60);
            this.ingresoManual_pnl.TabIndex = 43;
            this.ingresoManual_pnl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nueva Contraseña:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 4);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Repita Contraseña:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contraseniaAnterior_flp
            // 
            this.contraseniaAnterior_flp.Controls.Add(this.label2);
            this.contraseniaAnterior_flp.Controls.Add(this.tipo_lbl);
            this.contraseniaAnterior_flp.Controls.Add(this.mostrarCodigo_lnk);
            this.contraseniaAnterior_flp.Controls.Add(this.cambioModoIngresoContraseña_lnk);
            this.contraseniaAnterior_flp.Location = new System.Drawing.Point(6, 20);
            this.contraseniaAnterior_flp.Name = "contraseniaAnterior_flp";
            this.contraseniaAnterior_flp.Size = new System.Drawing.Size(460, 58);
            this.contraseniaAnterior_flp.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Actual:";
            // 
            // tipo_lbl
            // 
            this.tipo_lbl.AutoSize = true;
            this.tipo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tipo_lbl.Location = new System.Drawing.Point(49, 0);
            this.tipo_lbl.Name = "tipo_lbl";
            this.tipo_lbl.Size = new System.Drawing.Size(87, 13);
            this.tipo_lbl.TabIndex = 45;
            this.tipo_lbl.Text = "Código Temporal";
            this.tipo_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mostrarCodigo_lnk
            // 
            this.mostrarCodigo_lnk.AutoSize = true;
            this.mostrarCodigo_lnk.Location = new System.Drawing.Point(142, 0);
            this.mostrarCodigo_lnk.Name = "mostrarCodigo_lnk";
            this.mostrarCodigo_lnk.Size = new System.Drawing.Size(45, 13);
            this.mostrarCodigo_lnk.TabIndex = 47;
            this.mostrarCodigo_lnk.TabStop = true;
            this.mostrarCodigo_lnk.Text = "Mostrar ";
            this.mostrarCodigo_lnk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostrarCodigo_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mostrarCodigo_lnk_LinkClicked);
            // 
            // cambioModoIngresoContraseña_lnk
            // 
            this.cambioModoIngresoContraseña_lnk.AutoSize = true;
            this.cambioModoIngresoContraseña_lnk.Location = new System.Drawing.Point(193, 0);
            this.cambioModoIngresoContraseña_lnk.Name = "cambioModoIngresoContraseña_lnk";
            this.cambioModoIngresoContraseña_lnk.Size = new System.Drawing.Size(102, 13);
            this.cambioModoIngresoContraseña_lnk.TabIndex = 48;
            this.cambioModoIngresoContraseña_lnk.TabStop = true;
            this.cambioModoIngresoContraseña_lnk.Text = "Cambiar Contraseña";
            this.cambioModoIngresoContraseña_lnk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cambioModoIngresoContraseña_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cambioModoIngresoContraseña_lnk_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cambioRequerido_chk);
            this.groupBox1.Controls.Add(this.contraseniaAnterior_flp);
            this.groupBox1.Controls.Add(this.ingresoManual_pnl);
            this.groupBox1.Location = new System.Drawing.Point(77, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 82);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contraseña";
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
            this.ingresoManual_pnl.ResumeLayout(false);
            this.ingresoManual_pnl.PerformLayout();
            this.contraseniaAnterior_flp.ResumeLayout(false);
            this.contraseniaAnterior_flp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.TextBox contrasenia1_txt;
        protected internal System.Windows.Forms.TextBox contrasenia2_txt;
        protected internal System.Windows.Forms.Button cancelarContraseña_cmd;
        protected internal System.Windows.Forms.LinkLabel mostrarCaracteres_lnk;
        protected System.Windows.Forms.Panel ingresoManual_pnl;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label tipo_lbl;
        protected internal System.Windows.Forms.LinkLabel mostrarCodigo_lnk;
        protected internal System.Windows.Forms.LinkLabel cambioModoIngresoContraseña_lnk;
        protected System.Windows.Forms.FlowLayoutPanel contraseniaAnterior_flp;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label6;
    }
}