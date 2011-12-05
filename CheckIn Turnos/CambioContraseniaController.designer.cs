namespace CheckIn_Turnos
{
    partial class CambioContraseniaForm
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
            this.mostrar_lnk = new System.Windows.Forms.LinkLabel();
            this.aceptar_cmd = new System.Windows.Forms.Button();
            this.contrasenia2_txt = new System.Windows.Forms.TextBox();
            this.ingreseContra2_lbl = new System.Windows.Forms.Label();
            this.contrasenia1_txt = new System.Windows.Forms.TextBox();
            this.ingreseContraseña_lbl = new System.Windows.Forms.Label();
            this.editar_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editar_pic)).BeginInit();
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
            this.cancelar_cmd.TabIndex = 23;
            this.cancelar_cmd.Text = "Cancelar";
            this.cancelar_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelar_cmd.UseVisualStyleBackColor = true;
            this.cancelar_cmd.Click += new System.EventHandler(this.cancelar_cmd_Click);
            // 
            // mostrar_lnk
            // 
            this.mostrar_lnk.AutoSize = true;
            this.mostrar_lnk.Location = new System.Drawing.Point(243, 28);
            this.mostrar_lnk.Name = "mostrar_lnk";
            this.mostrar_lnk.Size = new System.Drawing.Size(42, 13);
            this.mostrar_lnk.TabIndex = 21;
            this.mostrar_lnk.TabStop = true;
            this.mostrar_lnk.Text = "Mostrar";
            this.mostrar_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mostrar_lnk_LinkClicked);
            // 
            // aceptar_cmd
            // 
            this.aceptar_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptar_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Accion_Aceptar;
            this.aceptar_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptar_cmd.Location = new System.Drawing.Point(218, 103);
            this.aceptar_cmd.Name = "aceptar_cmd";
            this.aceptar_cmd.Size = new System.Drawing.Size(75, 25);
            this.aceptar_cmd.TabIndex = 20;
            this.aceptar_cmd.Text = "Guardar";
            this.aceptar_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aceptar_cmd.UseVisualStyleBackColor = true;
            this.aceptar_cmd.Click += new System.EventHandler(this.aceptar_cmd_Click);
            // 
            // contrasenia2_txt
            // 
            this.contrasenia2_txt.Location = new System.Drawing.Point(69, 67);
            this.contrasenia2_txt.Name = "contrasenia2_txt";
            this.contrasenia2_txt.Size = new System.Drawing.Size(168, 20);
            this.contrasenia2_txt.TabIndex = 19;
            this.contrasenia2_txt.UseSystemPasswordChar = true;
            // 
            // ingreseContra2_lbl
            // 
            this.ingreseContra2_lbl.AutoSize = true;
            this.ingreseContra2_lbl.Location = new System.Drawing.Point(66, 51);
            this.ingreseContra2_lbl.Name = "ingreseContra2_lbl";
            this.ingreseContra2_lbl.Size = new System.Drawing.Size(108, 13);
            this.ingreseContra2_lbl.TabIndex = 18;
            this.ingreseContra2_lbl.Text = "Repita la contraseña:";
            // 
            // contrasenia1_txt
            // 
            this.contrasenia1_txt.Location = new System.Drawing.Point(69, 25);
            this.contrasenia1_txt.Name = "contrasenia1_txt";
            this.contrasenia1_txt.Size = new System.Drawing.Size(168, 20);
            this.contrasenia1_txt.TabIndex = 17;
            this.contrasenia1_txt.UseSystemPasswordChar = true;
            // 
            // ingreseContraseña_lbl
            // 
            this.ingreseContraseña_lbl.AutoSize = true;
            this.ingreseContraseña_lbl.Location = new System.Drawing.Point(66, 9);
            this.ingreseContraseña_lbl.Name = "ingreseContraseña_lbl";
            this.ingreseContraseña_lbl.Size = new System.Drawing.Size(148, 13);
            this.ingreseContraseña_lbl.TabIndex = 16;
            this.ingreseContraseña_lbl.Text = "Ingrese su nueva contraseña:";
            // 
            // editar_pic
            // 
            this.editar_pic.Image = global::CheckIn_Turnos.Properties.Resources.GrandeEditar;
            this.editar_pic.Location = new System.Drawing.Point(12, 12);
            this.editar_pic.Name = "editar_pic";
            this.editar_pic.Size = new System.Drawing.Size(48, 48);
            this.editar_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.editar_pic.TabIndex = 22;
            this.editar_pic.TabStop = false;
            // 
            // CambioContraseniaController
            // 
            this.AcceptButton = this.aceptar_cmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar_cmd;
            this.ClientSize = new System.Drawing.Size(305, 138);
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
            this.Name = "CambioContraseniaController";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.editar_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cancelar_cmd;
        internal System.Windows.Forms.PictureBox editar_pic;
        internal System.Windows.Forms.LinkLabel mostrar_lnk;
        internal System.Windows.Forms.Button aceptar_cmd;
        internal System.Windows.Forms.TextBox contrasenia2_txt;
        internal System.Windows.Forms.Label ingreseContra2_lbl;
        internal System.Windows.Forms.TextBox contrasenia1_txt;
        internal System.Windows.Forms.Label ingreseContraseña_lbl;
    }
}