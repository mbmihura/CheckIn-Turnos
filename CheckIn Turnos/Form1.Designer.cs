namespace CheckIn_Turnos
{
    partial class TurnosForm
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
            this.contrasenia_cmd = new System.Windows.Forms.Button();
            this.fecha_lbl = new System.Windows.Forms.Label();
            this.hora_lbl = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.CerrarTurno_cmd = new System.Windows.Forms.Button();
            this.abrirTurno_cmd = new System.Windows.Forms.Button();
            this.administracion_cmd = new System.Windows.Forms.Button();
            this.turnos_lv = new System.Windows.Forms.ListView();
            this.nombre_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.horaEntrada_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tiempo_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contrasenia_cmd
            // 
            this.contrasenia_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Contraseña;
            this.contrasenia_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contrasenia_cmd.Location = new System.Drawing.Point(12, 355);
            this.contrasenia_cmd.Name = "contrasenia_cmd";
            this.contrasenia_cmd.Size = new System.Drawing.Size(132, 27);
            this.contrasenia_cmd.TabIndex = 31;
            this.contrasenia_cmd.Text = "Cambiar contraseña";
            this.contrasenia_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contrasenia_cmd.UseVisualStyleBackColor = true;
            // 
            // fecha_lbl
            // 
            this.fecha_lbl.Location = new System.Drawing.Point(12, 9);
            this.fecha_lbl.Name = "fecha_lbl";
            this.fecha_lbl.Size = new System.Drawing.Size(436, 14);
            this.fecha_lbl.TabIndex = 32;
            this.fecha_lbl.Text = "Fechagq";
            this.fecha_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hora_lbl
            // 
            this.hora_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_lbl.Location = new System.Drawing.Point(-5, 23);
            this.hora_lbl.Name = "hora_lbl";
            this.hora_lbl.Size = new System.Drawing.Size(470, 32);
            this.hora_lbl.TabIndex = 30;
            this.hora_lbl.Text = "Hora: 00:00";
            this.hora_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.CerrarTurno_cmd);
            this.Panel1.Controls.Add(this.abrirTurno_cmd);
            this.Panel1.Location = new System.Drawing.Point(75, 66);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(311, 53);
            this.Panel1.TabIndex = 29;
            // 
            // CerrarTurno_cmd
            // 
            this.CerrarTurno_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarTurno_cmd.Image = global::CheckIn_Turnos.Properties.Resources.GrandeElimnar;
            this.CerrarTurno_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CerrarTurno_cmd.Location = new System.Drawing.Point(173, 3);
            this.CerrarTurno_cmd.Name = "CerrarTurno_cmd";
            this.CerrarTurno_cmd.Size = new System.Drawing.Size(135, 48);
            this.CerrarTurno_cmd.TabIndex = 4;
            this.CerrarTurno_cmd.Text = "Cerrar Turno";
            this.CerrarTurno_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CerrarTurno_cmd.UseVisualStyleBackColor = true;
            // 
            // abrirTurno_cmd
            // 
            this.abrirTurno_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirTurno_cmd.Image = global::CheckIn_Turnos.Properties.Resources.GrandeNuevo;
            this.abrirTurno_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abrirTurno_cmd.Location = new System.Drawing.Point(3, 3);
            this.abrirTurno_cmd.Name = "abrirTurno_cmd";
            this.abrirTurno_cmd.Size = new System.Drawing.Size(135, 48);
            this.abrirTurno_cmd.TabIndex = 3;
            this.abrirTurno_cmd.Text = "Abrir Turno";
            this.abrirTurno_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abrirTurno_cmd.UseVisualStyleBackColor = true;
            // 
            // administracion_cmd
            // 
            this.administracion_cmd.Location = new System.Drawing.Point(316, 355);
            this.administracion_cmd.Name = "administracion_cmd";
            this.administracion_cmd.Size = new System.Drawing.Size(132, 27);
            this.administracion_cmd.TabIndex = 28;
            this.administracion_cmd.Text = "Administración";
            this.administracion_cmd.UseVisualStyleBackColor = true;
            // 
            // turnos_lv
            // 
            this.turnos_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre_col,
            this.horaEntrada_col,
            this.tiempo_col});
            this.turnos_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.turnos_lv.Location = new System.Drawing.Point(12, 125);
            this.turnos_lv.MultiSelect = false;
            this.turnos_lv.Name = "turnos_lv";
            this.turnos_lv.ShowGroups = false;
            this.turnos_lv.Size = new System.Drawing.Size(436, 224);
            this.turnos_lv.TabIndex = 27;
            this.turnos_lv.UseCompatibleStateImageBehavior = false;
            this.turnos_lv.View = System.Windows.Forms.View.Details;
            // 
            // nombre_col
            // 
            this.nombre_col.Text = "Nombre";
            this.nombre_col.Width = 101;
            // 
            // horaEntrada_col
            // 
            this.horaEntrada_col.Text = "Hora de Entrada";
            this.horaEntrada_col.Width = 109;
            // 
            // tiempo_col
            // 
            this.tiempo_col.Text = "Tiempo";
            this.tiempo_col.Width = 105;
            // 
            // TurnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 391);
            this.Controls.Add(this.contrasenia_cmd);
            this.Controls.Add(this.fecha_lbl);
            this.Controls.Add(this.hora_lbl);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.administracion_cmd);
            this.Controls.Add(this.turnos_lv);
            this.MinimumSize = new System.Drawing.Size(350, 279);
            this.Name = "TurnosForm";
            this.Text = "Gestión de Turnos";
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button contrasenia_cmd;
        internal System.Windows.Forms.Label fecha_lbl;
        internal System.Windows.Forms.Label hora_lbl;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button CerrarTurno_cmd;
        internal System.Windows.Forms.Button abrirTurno_cmd;
        internal System.Windows.Forms.Button administracion_cmd;
        internal System.Windows.Forms.ListView turnos_lv;
        internal System.Windows.Forms.ColumnHeader nombre_col;
        internal System.Windows.Forms.ColumnHeader horaEntrada_col;
        internal System.Windows.Forms.ColumnHeader tiempo_col;
    }
}

