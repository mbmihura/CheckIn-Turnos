namespace CheckIn_Turnos
{
    partial class CambioContraseñaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioContraseñaForm));
            this.cancelar_cmd = new System.Windows.Forms.Button();
            this.mostrar_lnk = new System.Windows.Forms.LinkLabel();
            this.aceptar_cmd = new System.Windows.Forms.Button();
            this.contrasenia2_txt = new System.Windows.Forms.TextBox();
            this.ingreseContra2_lbl = new System.Windows.Forms.Label();
            this.contrasenia1_txt = new System.Windows.Forms.TextBox();
            this.ingreseContraseña_lbl = new System.Windows.Forms.Label();
            this.editar_pic = new System.Windows.Forms.PictureBox();
            this.cambioRequerido_pnl = new System.Windows.Forms.Panel();
            this.cambioRequerido_lbl = new System.Windows.Forms.Label();
            this.cambioRequeridoIma_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.editar_pic)).BeginInit();
            this.cambioRequerido_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar_cmd
            // 
            this.cancelar_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelar_cmd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Accion_Eliminar;
            this.cancelar_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelar_cmd.Location = new System.Drawing.Point(12, 104);
            this.cancelar_cmd.Name = "cancelar_cmd";
            this.cancelar_cmd.Size = new System.Drawing.Size(75, 25);
            this.cancelar_cmd.TabIndex = 4;
            this.cancelar_cmd.Text = "&Cancelar";
            this.cancelar_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.cancelar_cmd, "Presione la tecla \'Esc\' para salir sin guardar.");
            this.cancelar_cmd.UseVisualStyleBackColor = true;
            // 
            // mostrar_lnk
            // 
            this.mostrar_lnk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrar_lnk.AutoSize = true;
            this.mostrar_lnk.Location = new System.Drawing.Point(286, 28);
            this.mostrar_lnk.Name = "mostrar_lnk";
            this.mostrar_lnk.Size = new System.Drawing.Size(42, 13);
            this.mostrar_lnk.TabIndex = 21;
            this.mostrar_lnk.TabStop = true;
            this.mostrar_lnk.Text = "Mostrar";
            this.toolTip1.SetToolTip(this.mostrar_lnk, "Haga click alternar entre mostrar y ocultar la contraseña que ingresó.");
            this.mostrar_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mostrar_lnk_LinkClicked);
            // 
            // aceptar_cmd
            // 
            this.aceptar_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptar_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Accion_Aceptar;
            this.aceptar_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptar_cmd.Location = new System.Drawing.Point(261, 103);
            this.aceptar_cmd.Name = "aceptar_cmd";
            this.aceptar_cmd.Size = new System.Drawing.Size(75, 25);
            this.aceptar_cmd.TabIndex = 2;
            this.aceptar_cmd.Text = "Guardar";
            this.aceptar_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.aceptar_cmd, "Presione la tecla Enter para guardar y salir.");
            this.aceptar_cmd.UseVisualStyleBackColor = true;
            this.aceptar_cmd.Click += new System.EventHandler(this.aceptar_cmd_Click);
            // 
            // contrasenia2_txt
            // 
            this.contrasenia2_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.contrasenia2_txt.Location = new System.Drawing.Point(69, 67);
            this.contrasenia2_txt.Name = "contrasenia2_txt";
            this.contrasenia2_txt.Size = new System.Drawing.Size(211, 20);
            this.contrasenia2_txt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.contrasenia2_txt, "Repita la contraseña ingresada previamente.");
            this.contrasenia2_txt.UseSystemPasswordChar = true;
            // 
            // ingreseContra2_lbl
            // 
            this.ingreseContra2_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ingreseContra2_lbl.AutoSize = true;
            this.ingreseContra2_lbl.Location = new System.Drawing.Point(66, 51);
            this.ingreseContra2_lbl.Name = "ingreseContra2_lbl";
            this.ingreseContra2_lbl.Size = new System.Drawing.Size(108, 13);
            this.ingreseContra2_lbl.TabIndex = 18;
            this.ingreseContra2_lbl.Text = "Repita la contraseña:";
            // 
            // contrasenia1_txt
            // 
            this.contrasenia1_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.contrasenia1_txt.Location = new System.Drawing.Point(69, 25);
            this.contrasenia1_txt.Name = "contrasenia1_txt";
            this.contrasenia1_txt.Size = new System.Drawing.Size(211, 20);
            this.contrasenia1_txt.TabIndex = 0;
            this.toolTip1.SetToolTip(this.contrasenia1_txt, "Ingrese su nueva contraseña.");
            this.contrasenia1_txt.UseSystemPasswordChar = true;
            // 
            // ingreseContraseña_lbl
            // 
            this.ingreseContraseña_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ingreseContraseña_lbl.AutoSize = true;
            this.ingreseContraseña_lbl.Location = new System.Drawing.Point(66, 9);
            this.ingreseContraseña_lbl.Name = "ingreseContraseña_lbl";
            this.ingreseContraseña_lbl.Size = new System.Drawing.Size(148, 13);
            this.ingreseContraseña_lbl.TabIndex = 16;
            this.ingreseContraseña_lbl.Text = "Ingrese su nueva contraseña:";
            // 
            // editar_pic
            // 
            this.editar_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editar_pic.Image = global::CheckIn_Turnos.Properties.Resources.GrandeEditar;
            this.editar_pic.Location = new System.Drawing.Point(12, 12);
            this.editar_pic.Name = "editar_pic";
            this.editar_pic.Size = new System.Drawing.Size(48, 48);
            this.editar_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.editar_pic.TabIndex = 22;
            this.editar_pic.TabStop = false;
            // 
            // cambioRequerido_pnl
            // 
            this.cambioRequerido_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cambioRequerido_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(191)))));
            this.cambioRequerido_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cambioRequerido_pnl.Controls.Add(this.cambioRequerido_lbl);
            this.cambioRequerido_pnl.Controls.Add(this.cambioRequeridoIma_lbl);
            this.cambioRequerido_pnl.Location = new System.Drawing.Point(5, 5);
            this.cambioRequerido_pnl.Name = "cambioRequerido_pnl";
            this.cambioRequerido_pnl.Size = new System.Drawing.Size(338, 54);
            this.cambioRequerido_pnl.TabIndex = 25;
            this.cambioRequerido_pnl.Visible = false;
            // 
            // cambioRequerido_lbl
            // 
            this.cambioRequerido_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cambioRequerido_lbl.Location = new System.Drawing.Point(53, 0);
            this.cambioRequerido_lbl.Name = "cambioRequerido_lbl";
            this.cambioRequerido_lbl.Size = new System.Drawing.Size(284, 52);
            this.cambioRequerido_lbl.TabIndex = 18;
            this.cambioRequerido_lbl.Text = "Debe cambiar su contraseña por una nueva antes de seguir utilizando el sistema, y" +
                "a que uno de los administradores solicitó que se hiciera.";
            this.cambioRequerido_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cambioRequeridoIma_lbl
            // 
            this.cambioRequeridoIma_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.cambioRequeridoIma_lbl.AutoEllipsis = true;
            this.cambioRequeridoIma_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(191)))));
            this.cambioRequeridoIma_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambioRequeridoIma_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioRequeridoIma_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(71)))), ((int)(((byte)(33)))));
            this.cambioRequeridoIma_lbl.Image = ((System.Drawing.Image)(resources.GetObject("cambioRequeridoIma_lbl.Image")));
            this.cambioRequeridoIma_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cambioRequeridoIma_lbl.Location = new System.Drawing.Point(-1, 0);
            this.cambioRequeridoIma_lbl.Name = "cambioRequeridoIma_lbl";
            this.cambioRequeridoIma_lbl.Size = new System.Drawing.Size(48, 52);
            this.cambioRequeridoIma_lbl.TabIndex = 17;
            this.cambioRequeridoIma_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CambioContraseñaForm
            // 
            this.AcceptButton = this.aceptar_cmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar_cmd;
            this.ClientSize = new System.Drawing.Size(348, 138);
            this.Controls.Add(this.cambioRequerido_pnl);
            this.Controls.Add(this.cancelar_cmd);
            this.Controls.Add(this.editar_pic);
            this.Controls.Add(this.mostrar_lnk);
            this.Controls.Add(this.aceptar_cmd);
            this.Controls.Add(this.contrasenia2_txt);
            this.Controls.Add(this.ingreseContra2_lbl);
            this.Controls.Add(this.contrasenia1_txt);
            this.Controls.Add(this.ingreseContraseña_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambioContraseñaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.editar_pic)).EndInit();
            this.cambioRequerido_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Button cancelar_cmd;
        protected internal System.Windows.Forms.PictureBox editar_pic;
        protected internal System.Windows.Forms.LinkLabel mostrar_lnk;
        protected internal System.Windows.Forms.Button aceptar_cmd;
        protected internal System.Windows.Forms.TextBox contrasenia2_txt;
        protected internal System.Windows.Forms.Label ingreseContra2_lbl;
        protected internal System.Windows.Forms.TextBox contrasenia1_txt;
        protected internal System.Windows.Forms.Label ingreseContraseña_lbl;
        internal System.Windows.Forms.Panel cambioRequerido_pnl;
        private System.Windows.Forms.Label cambioRequerido_lbl;
        internal System.Windows.Forms.Label cambioRequeridoIma_lbl;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}