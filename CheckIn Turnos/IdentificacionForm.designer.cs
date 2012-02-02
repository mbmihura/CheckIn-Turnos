namespace CheckIn_Turnos
{
    partial class IdentificacionForm
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
            this.ingresar_cmd = new System.Windows.Forms.Button();
            this.contrasenia_txt = new System.Windows.Forms.TextBox();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.contraseña_lbl = new System.Windows.Forms.Label();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.explicacion_lbl = new System.Windows.Forms.Label();
            this.candado_pic = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.candado_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresar_cmd
            // 
            this.ingresar_cmd.Location = new System.Drawing.Point(159, 87);
            this.ingresar_cmd.Name = "ingresar_cmd";
            this.ingresar_cmd.Size = new System.Drawing.Size(75, 23);
            this.ingresar_cmd.TabIndex = 2;
            this.ingresar_cmd.Text = "Ingresar";
            this.toolTip1.SetToolTip(this.ingresar_cmd, "Presione la tecla Enter para continuar.");
            this.ingresar_cmd.UseVisualStyleBackColor = true;
            this.ingresar_cmd.Click += new System.EventHandler(this.ingresar_cmd_Click);
            // 
            // contrasenia_txt
            // 
            this.contrasenia_txt.Location = new System.Drawing.Point(159, 61);
            this.contrasenia_txt.Name = "contrasenia_txt";
            this.contrasenia_txt.Size = new System.Drawing.Size(132, 20);
            this.contrasenia_txt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.contrasenia_txt, "Ingrese su contraseña.");
            this.contrasenia_txt.UseSystemPasswordChar = true;
            // 
            // usuario_txt
            // 
            this.usuario_txt.Location = new System.Drawing.Point(159, 35);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(132, 20);
            this.usuario_txt.TabIndex = 0;
            this.toolTip1.SetToolTip(this.usuario_txt, "Ingrese su usuario.");
            // 
            // contraseña_lbl
            // 
            this.contraseña_lbl.AutoSize = true;
            this.contraseña_lbl.Location = new System.Drawing.Point(89, 64);
            this.contraseña_lbl.Name = "contraseña_lbl";
            this.contraseña_lbl.Size = new System.Drawing.Size(64, 13);
            this.contraseña_lbl.TabIndex = 17;
            this.contraseña_lbl.Text = "Contraseña:";
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Location = new System.Drawing.Point(89, 38);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(46, 13);
            this.usuario_lbl.TabIndex = 16;
            this.usuario_lbl.Text = "Usuario:";
            // 
            // explicacion_lbl
            // 
            this.explicacion_lbl.AutoSize = true;
            this.explicacion_lbl.Location = new System.Drawing.Point(89, 9);
            this.explicacion_lbl.Name = "explicacion_lbl";
            this.explicacion_lbl.Size = new System.Drawing.Size(173, 13);
            this.explicacion_lbl.TabIndex = 15;
            this.explicacion_lbl.Text = "Ingrese sus datos para identificarse";
            // 
            // candado_pic
            // 
            this.candado_pic.Image = global::CheckIn_Turnos.Properties.Resources.GrandeCandado;
            this.candado_pic.Location = new System.Drawing.Point(19, 20);
            this.candado_pic.Name = "candado_pic";
            this.candado_pic.Size = new System.Drawing.Size(70, 69);
            this.candado_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.candado_pic.TabIndex = 21;
            this.candado_pic.TabStop = false;
            // 
            // IdentificacionForm
            // 
            this.AcceptButton = this.ingresar_cmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 119);
            this.Controls.Add(this.ingresar_cmd);
            this.Controls.Add(this.contrasenia_txt);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.contraseña_lbl);
            this.Controls.Add(this.usuario_lbl);
            this.Controls.Add(this.explicacion_lbl);
            this.Controls.Add(this.candado_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IdentificacionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Identificacion de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.candado_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox contrasenia_txt;
        internal System.Windows.Forms.TextBox usuario_txt;
        internal System.Windows.Forms.Label contraseña_lbl;
        internal System.Windows.Forms.Label usuario_lbl;
        internal System.Windows.Forms.Label explicacion_lbl;
        internal System.Windows.Forms.PictureBox candado_pic;
        protected System.Windows.Forms.Button ingresar_cmd;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}