namespace CheckIn_Turnos
{
    partial class UsuarioNuevoForm
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
            this.ingresoManual_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accion_pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guardar_cmd
            // 
            this.guardar_cmd.Click += new System.EventHandler(this.guardar_cmd_Click);
            // 
            // accion_pic
            // 
            this.accion_pic.Image = global::CheckIn_Turnos.Properties.Resources.GrandeNuevo;
            // 
            // admin_chk
            // 
            this.admin_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // UsuarioNuevoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 265);
            this.Name = "UsuarioNuevoForm";
            this.Text = "Usuario Nuevo";
            this.ingresoManual_pnl.ResumeLayout(false);
            this.ingresoManual_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accion_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
