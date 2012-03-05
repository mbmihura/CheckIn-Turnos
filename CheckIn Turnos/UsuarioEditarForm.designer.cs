namespace CheckIn_Turnos
{
    partial class UsuarioEditarForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cambiarContraseña_lnk = new System.Windows.Forms.LinkLabel();
            this.CancelarCambioContraseña_cmd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accion_pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contrasenia1_txt
            // 
            this.contrasenia1_txt.TabIndex = 4;
            this.toolTip.SetToolTip(this.contrasenia1_txt, "Ingrese una contaseña para que el usuario se identifique.");
            this.contrasenia1_txt.Visible = false;
            // 
            // contrasenia2_txt
            // 
            this.contrasenia2_txt.TabIndex = 5;
            this.toolTip.SetToolTip(this.contrasenia2_txt, "Repita la contraseña ingresada.");
            this.contrasenia2_txt.Visible = false;
            // 
            // mostrarCaracteres_lnk
            // 
            this.mostrarCaracteres_lnk.TabIndex = 6;
            this.toolTip.SetToolTip(this.mostrarCaracteres_lnk, "Haga click para mostrar la contraseña que ingresó.");
            this.mostrarCaracteres_lnk.Visible = false;
            // 
            // repetirContraseña_lbl
            // 
            this.repetirContraseña_lbl.Visible = false;
            // 
            // cancelar_cmd
            // 
            this.cancelar_cmd.TabIndex = 12;
            this.toolTip.SetToolTip(this.cancelar_cmd, "Presione la tecla \'C\' para salir sin guardar.");
            // 
            // guardar_cmd
            // 
            this.guardar_cmd.TabIndex = 11;
            this.toolTip.SetToolTip(this.guardar_cmd, "Presione la tecla \'G\' para guardar y salir.");
            this.guardar_cmd.Click += new System.EventHandler(this.guardar_cmd_Click);
            // 
            // cambioRequerido_chk
            // 
            this.cambioRequerido_chk.TabIndex = 7;
            this.toolTip.SetToolTip(this.cambioRequerido_chk, "Obliga al usuario a tener que cambiar la contraseña por una diferente la próxima " +
                    "vez que use el sistema.");
            // 
            // usuario_txt
            // 
            this.toolTip.SetToolTip(this.usuario_txt, "Ingrese el usuario (Debe ser único en el sistema).");
            this.usuario_txt.TextChanged += new System.EventHandler(this.usuario_txt_TextChanged);
            // 
            // nombre_txt
            // 
            this.toolTip.SetToolTip(this.nombre_txt, "Ingrese el nombre del usuario.");
            // 
            // accion_pic
            // 
            this.accion_pic.Image = global::CheckIn_Turnos.Properties.Resources.GrandeEditar;
            // 
            // admin_chk
            // 
            this.admin_chk.TabIndex = 10;
            this.toolTip.SetToolTip(this.admin_chk, "Habilita al usuario a usar las funciones administrativas.");
            // 
            // habilitado_chk
            // 
            this.habilitado_chk.TabIndex = 9;
            this.toolTip.SetToolTip(this.habilitado_chk, "Habilita al usuario para que pueda usar el sistema.");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelarCambioContraseña_cmd);
            this.panel1.Controls.Add(this.cambiarContraseña_lnk);
            this.panel1.Controls.SetChildIndex(this.nombreValidacion_lbl, 0);
            this.panel1.Controls.SetChildIndex(this.usuarioValidacion_lbl, 0);
            this.panel1.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.Controls.SetChildIndex(this.usuario_txt, 0);
            this.panel1.Controls.SetChildIndex(this.admin_chk, 0);
            this.panel1.Controls.SetChildIndex(this.nombre_txt, 0);
            this.panel1.Controls.SetChildIndex(this.habilitado_chk, 0);
            this.panel1.Controls.SetChildIndex(this.Label1, 0);
            this.panel1.Controls.SetChildIndex(this.accion_pic, 0);
            this.panel1.Controls.SetChildIndex(this.label6, 0);
            this.panel1.Controls.SetChildIndex(this.Label3, 0);
            this.panel1.Controls.SetChildIndex(this.cambiarContraseña_lnk, 0);
            this.panel1.Controls.SetChildIndex(this.CancelarCambioContraseña_cmd, 0);
            // 
            // contraseñaValidacion_lbl
            // 
            this.contraseñaValidacion_lbl.AutoSize = false;
            this.contraseñaValidacion_lbl.Size = new System.Drawing.Size(164, 29);
            // 
            // cambiarContraseña_lnk
            // 
            this.cambiarContraseña_lnk.AutoSize = true;
            this.cambiarContraseña_lnk.Location = new System.Drawing.Point(156, 112);
            this.cambiarContraseña_lnk.Name = "cambiarContraseña_lnk";
            this.cambiarContraseña_lnk.Size = new System.Drawing.Size(54, 13);
            this.cambiarContraseña_lnk.TabIndex = 3;
            this.cambiarContraseña_lnk.TabStop = true;
            this.cambiarContraseña_lnk.Text = "Cambiar...";
            this.toolTip.SetToolTip(this.cambiarContraseña_lnk, "Haga click para cambiar la contraseña actual del usuario por otra.");
            this.cambiarContraseña_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cambiarContraseña_lnk_LinkClicked);
            // 
            // CancelarCambioContraseña_cmd
            // 
            this.CancelarCambioContraseña_cmd.Location = new System.Drawing.Point(499, 144);
            this.CancelarCambioContraseña_cmd.Name = "CancelarCambioContraseña_cmd";
            this.CancelarCambioContraseña_cmd.Size = new System.Drawing.Size(66, 23);
            this.CancelarCambioContraseña_cmd.TabIndex = 8;
            this.CancelarCambioContraseña_cmd.Text = "Cancelar";
            this.toolTip.SetToolTip(this.CancelarCambioContraseña_cmd, "Cancela el cambio de contraseña, la contraseña previa queda vigente.");
            this.CancelarCambioContraseña_cmd.UseVisualStyleBackColor = true;
            this.CancelarCambioContraseña_cmd.Visible = false;
            this.CancelarCambioContraseña_cmd.Click += new System.EventHandler(this.CancelarCambioContraseña_cmd_Click);
            // 
            // UsuarioEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 265);
            this.Name = "UsuarioEditarForm";
            this.Text = "Editar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.accion_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarCambioContraseña_cmd;
        private System.Windows.Forms.LinkLabel cambiarContraseña_lnk;
    }
}
