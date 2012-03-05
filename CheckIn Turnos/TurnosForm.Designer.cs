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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnosForm));
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
            this.horaYTurnosAbiertos_tmr = new System.Windows.Forms.Timer(this.components);
            this.notificacion_pnl = new System.Windows.Forms.Panel();
            this.notificacion_lbl = new System.Windows.Forms.Label();
            this.NotificacionIma_lbl = new System.Windows.Forms.Label();
            this.notificacion_tmr = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1.SuspendLayout();
            this.notificacion_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // contrasenia_cmd
            // 
            this.contrasenia_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Contraseña;
            this.contrasenia_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contrasenia_cmd.Location = new System.Drawing.Point(12, 355);
            this.contrasenia_cmd.Name = "contrasenia_cmd";
            this.contrasenia_cmd.Size = new System.Drawing.Size(132, 27);
            this.contrasenia_cmd.TabIndex = 3;
            this.contrasenia_cmd.Text = "Ca&mbiar contraseña";
            this.contrasenia_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.contrasenia_cmd, "Presione la tecla \'M\' para cambiar la contraseña de un usuario.");
            this.contrasenia_cmd.UseVisualStyleBackColor = true;
            this.contrasenia_cmd.Click += new System.EventHandler(this.contrasenia_cmd_Click);
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
            this.CerrarTurno_cmd.TabIndex = 2;
            this.CerrarTurno_cmd.Text = "&Cerrar Turno";
            this.CerrarTurno_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.CerrarTurno_cmd, "Presione la tecla \'C\' para cerrar un turno actualmente abierto");
            this.CerrarTurno_cmd.UseVisualStyleBackColor = true;
            this.CerrarTurno_cmd.Click += new System.EventHandler(this.CerrarTurno_cmd_Click);
            // 
            // abrirTurno_cmd
            // 
            this.abrirTurno_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirTurno_cmd.Image = global::CheckIn_Turnos.Properties.Resources.GrandeNuevo;
            this.abrirTurno_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abrirTurno_cmd.Location = new System.Drawing.Point(3, 3);
            this.abrirTurno_cmd.Name = "abrirTurno_cmd";
            this.abrirTurno_cmd.Size = new System.Drawing.Size(135, 48);
            this.abrirTurno_cmd.TabIndex = 0;
            this.abrirTurno_cmd.Text = "&Abrir Turno";
            this.abrirTurno_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.abrirTurno_cmd, "Presione la tecla \'A\' para abrir un turno.");
            this.abrirTurno_cmd.UseVisualStyleBackColor = true;
            this.abrirTurno_cmd.Click += new System.EventHandler(this.abrirTurno_cmd_Click);
            // 
            // administracion_cmd
            // 
            this.administracion_cmd.Location = new System.Drawing.Point(316, 355);
            this.administracion_cmd.Name = "administracion_cmd";
            this.administracion_cmd.Size = new System.Drawing.Size(132, 27);
            this.administracion_cmd.TabIndex = 4;
            this.administracion_cmd.Text = "A&dministración";
            this.toolTip1.SetToolTip(this.administracion_cmd, "Presione la tecla \'D\' para entrar a las funciones administrativas.");
            this.administracion_cmd.UseVisualStyleBackColor = true;
            this.administracion_cmd.Click += new System.EventHandler(this.administracion_cmd_Click);
            // 
            // turnos_lv
            // 
            this.turnos_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre_col,
            this.horaEntrada_col,
            this.tiempo_col});
            this.turnos_lv.FullRowSelect = true;
            this.turnos_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.turnos_lv.Location = new System.Drawing.Point(12, 125);
            this.turnos_lv.MultiSelect = false;
            this.turnos_lv.Name = "turnos_lv";
            this.turnos_lv.ShowGroups = false;
            this.turnos_lv.Size = new System.Drawing.Size(436, 224);
            this.turnos_lv.TabIndex = 5;
            this.turnos_lv.UseCompatibleStateImageBehavior = false;
            this.turnos_lv.View = System.Windows.Forms.View.Details;
            this.turnos_lv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.turnos_lv_MouseDoubleClick);
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
            // horaYTurnosAbiertos_tmr
            // 
            this.horaYTurnosAbiertos_tmr.Enabled = true;
            this.horaYTurnosAbiertos_tmr.Interval = 5000;
            this.horaYTurnosAbiertos_tmr.Tick += new System.EventHandler(this.horaYTurnosAbiertos_tmr_Tick);
            // 
            // notificacion_pnl
            // 
            this.notificacion_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.notificacion_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.notificacion_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificacion_pnl.Controls.Add(this.notificacion_lbl);
            this.notificacion_pnl.Controls.Add(this.NotificacionIma_lbl);
            this.notificacion_pnl.Location = new System.Drawing.Point(15, 321);
            this.notificacion_pnl.Name = "notificacion_pnl";
            this.notificacion_pnl.Size = new System.Drawing.Size(281, 25);
            this.notificacion_pnl.TabIndex = 33;
            this.notificacion_pnl.Visible = false;
            // 
            // notificacion_lbl
            // 
            this.notificacion_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.notificacion_lbl.Location = new System.Drawing.Point(41, 0);
            this.notificacion_lbl.Name = "notificacion_lbl";
            this.notificacion_lbl.Size = new System.Drawing.Size(239, 23);
            this.notificacion_lbl.TabIndex = 18;
            this.notificacion_lbl.Text = "Turno abierto para usuario.";
            this.notificacion_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notificacion_lbl.Click += new System.EventHandler(this.notificacion_lbl_Click);
            // 
            // NotificacionIma_lbl
            // 
            this.NotificacionIma_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.NotificacionIma_lbl.AutoEllipsis = true;
            this.NotificacionIma_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(222)))));
            this.NotificacionIma_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificacionIma_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificacionIma_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(71)))), ((int)(((byte)(33)))));
            this.NotificacionIma_lbl.Image = ((System.Drawing.Image)(resources.GetObject("NotificacionIma_lbl.Image")));
            this.NotificacionIma_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NotificacionIma_lbl.Location = new System.Drawing.Point(-1, 0);
            this.NotificacionIma_lbl.Name = "NotificacionIma_lbl";
            this.NotificacionIma_lbl.Size = new System.Drawing.Size(44, 23);
            this.NotificacionIma_lbl.TabIndex = 17;
            this.NotificacionIma_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificacionIma_lbl.Click += new System.EventHandler(this.NotificacionIma_lbl_Click);
            // 
            // notificacion_tmr
            // 
            this.notificacion_tmr.Interval = 5000;
            this.notificacion_tmr.Tick += new System.EventHandler(this.notificacion_tmr_Tick);
            // 
            // TurnosForm
            // 
            this.AcceptButton = this.abrirTurno_cmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 391);
            this.Controls.Add(this.notificacion_pnl);
            this.Controls.Add(this.contrasenia_cmd);
            this.Controls.Add(this.fecha_lbl);
            this.Controls.Add(this.hora_lbl);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.administracion_cmd);
            this.Controls.Add(this.turnos_lv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 279);
            this.Name = "TurnosForm";
            this.Text = "Gestión de Turnos";
            this.Load += new System.EventHandler(this.TurnosForm_Load);
            this.Panel1.ResumeLayout(false);
            this.notificacion_pnl.ResumeLayout(false);
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
        private System.Windows.Forms.Timer horaYTurnosAbiertos_tmr;
        internal System.Windows.Forms.Panel notificacion_pnl;
        private System.Windows.Forms.Label notificacion_lbl;
        internal System.Windows.Forms.Label NotificacionIma_lbl;
        private System.Windows.Forms.Timer notificacion_tmr;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

