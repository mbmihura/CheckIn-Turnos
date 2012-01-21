namespace CheckIn_Turnos
{
    partial class AdministracionForm
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.usuarios_tab = new System.Windows.Forms.TabPage();
            this.usuario_dgv = new System.Windows.Forms.DataGridView();
            this.modificar_cmd = new System.Windows.Forms.Button();
            this.eliminar_cmd = new System.Windows.Forms.Button();
            this.nuevo_cmd = new System.Windows.Forms.Button();
            this.explicacion_lbl = new System.Windows.Forms.Label();
            this.turnos_tab = new System.Windows.Forms.TabPage();
            this.tabla_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.exportar_cmd = new System.Windows.Forms.Button();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.hasta_lbl = new System.Windows.Forms.Label();
            this.fechaHasta_dtp = new System.Windows.Forms.DateTimePicker();
            this.desde_chk = new System.Windows.Forms.CheckBox();
            this.fechaDesde_dtp = new System.Windows.Forms.DateTimePicker();
            this.turnos_dgv = new System.Windows.Forms.DataGridView();
            this.salir_cmd = new System.Windows.Forms.Button();
            this.Configuracion_lkl = new System.Windows.Forms.LinkLabel();
            this.exportar_sfd = new System.Windows.Forms.SaveFileDialog();
            this.TabControl1.SuspendLayout();
            this.usuarios_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuario_dgv)).BeginInit();
            this.turnos_tab.SuspendLayout();
            this.tabla_tlp.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnos_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.usuarios_tab);
            this.TabControl1.Controls.Add(this.turnos_tab);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(541, 339);
            this.TabControl1.TabIndex = 7;
            this.TabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.nombreODesde_checkedChangedOCambioDeTab);
            // 
            // usuarios_tab
            // 
            this.usuarios_tab.Controls.Add(this.usuario_dgv);
            this.usuarios_tab.Controls.Add(this.modificar_cmd);
            this.usuarios_tab.Controls.Add(this.eliminar_cmd);
            this.usuarios_tab.Controls.Add(this.nuevo_cmd);
            this.usuarios_tab.Controls.Add(this.explicacion_lbl);
            this.usuarios_tab.Location = new System.Drawing.Point(4, 22);
            this.usuarios_tab.Name = "usuarios_tab";
            this.usuarios_tab.Padding = new System.Windows.Forms.Padding(3);
            this.usuarios_tab.Size = new System.Drawing.Size(533, 313);
            this.usuarios_tab.TabIndex = 0;
            this.usuarios_tab.Text = "Usuarios";
            this.usuarios_tab.UseVisualStyleBackColor = true;
            // 
            // usuario_dgv
            // 
            this.usuario_dgv.AllowUserToAddRows = false;
            this.usuario_dgv.AllowUserToDeleteRows = false;
            this.usuario_dgv.AllowUserToResizeRows = false;
            this.usuario_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usuario_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuario_dgv.BackgroundColor = System.Drawing.Color.White;
            this.usuario_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usuario_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usuario_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuario_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.usuario_dgv.Location = new System.Drawing.Point(3, 19);
            this.usuario_dgv.MultiSelect = false;
            this.usuario_dgv.Name = "usuario_dgv";
            this.usuario_dgv.ReadOnly = true;
            this.usuario_dgv.RowHeadersVisible = false;
            this.usuario_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuario_dgv.Size = new System.Drawing.Size(422, 278);
            this.usuario_dgv.TabIndex = 10;
            // 
            // modificar_cmd
            // 
            this.modificar_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modificar_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Accion_Editar;
            this.modificar_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificar_cmd.Location = new System.Drawing.Point(431, 52);
            this.modificar_cmd.Name = "modificar_cmd";
            this.modificar_cmd.Size = new System.Drawing.Size(96, 25);
            this.modificar_cmd.TabIndex = 5;
            this.modificar_cmd.Text = "Modificar";
            this.modificar_cmd.UseVisualStyleBackColor = true;
            this.modificar_cmd.Click += new System.EventHandler(this.modificar_cmd_Click_1);
            // 
            // eliminar_cmd
            // 
            this.eliminar_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminar_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Accion_Eliminar;
            this.eliminar_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar_cmd.Location = new System.Drawing.Point(431, 85);
            this.eliminar_cmd.Name = "eliminar_cmd";
            this.eliminar_cmd.Size = new System.Drawing.Size(96, 25);
            this.eliminar_cmd.TabIndex = 4;
            this.eliminar_cmd.Text = "Eliminar";
            this.eliminar_cmd.UseVisualStyleBackColor = true;
            this.eliminar_cmd.Click += new System.EventHandler(this.eliminar_cmd_Click);
            // 
            // nuevo_cmd
            // 
            this.nuevo_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevo_cmd.Image = global::CheckIn_Turnos.Properties.Resources.Accion_Nuevo;
            this.nuevo_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevo_cmd.Location = new System.Drawing.Point(431, 19);
            this.nuevo_cmd.Name = "nuevo_cmd";
            this.nuevo_cmd.Size = new System.Drawing.Size(96, 25);
            this.nuevo_cmd.TabIndex = 3;
            this.nuevo_cmd.Text = "Nuevo";
            this.nuevo_cmd.UseVisualStyleBackColor = true;
            // 
            // explicacion_lbl
            // 
            this.explicacion_lbl.AutoSize = true;
            this.explicacion_lbl.Location = new System.Drawing.Point(3, 3);
            this.explicacion_lbl.Name = "explicacion_lbl";
            this.explicacion_lbl.Size = new System.Drawing.Size(106, 13);
            this.explicacion_lbl.TabIndex = 2;
            this.explicacion_lbl.Text = "Usuarios del sistema:";
            // 
            // turnos_tab
            // 
            this.turnos_tab.Controls.Add(this.tabla_tlp);
            this.turnos_tab.Location = new System.Drawing.Point(4, 22);
            this.turnos_tab.Name = "turnos_tab";
            this.turnos_tab.Padding = new System.Windows.Forms.Padding(3);
            this.turnos_tab.Size = new System.Drawing.Size(533, 313);
            this.turnos_tab.TabIndex = 1;
            this.turnos_tab.Text = "Turnos";
            this.turnos_tab.UseVisualStyleBackColor = true;
            // 
            // tabla_tlp
            // 
            this.tabla_tlp.ColumnCount = 1;
            this.tabla_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla_tlp.Controls.Add(this.exportar_cmd, 0, 2);
            this.tabla_tlp.Controls.Add(this.FlowLayoutPanel1, 0, 0);
            this.tabla_tlp.Controls.Add(this.turnos_dgv, 0, 1);
            this.tabla_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_tlp.Location = new System.Drawing.Point(3, 3);
            this.tabla_tlp.Margin = new System.Windows.Forms.Padding(0);
            this.tabla_tlp.Name = "tabla_tlp";
            this.tabla_tlp.RowCount = 3;
            this.tabla_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabla_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tabla_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabla_tlp.Size = new System.Drawing.Size(527, 307);
            this.tabla_tlp.TabIndex = 11;
            // 
            // exportar_cmd
            // 
            this.exportar_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportar_cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportar_cmd.Location = new System.Drawing.Point(421, 280);
            this.exportar_cmd.Name = "exportar_cmd";
            this.exportar_cmd.Size = new System.Drawing.Size(103, 24);
            this.exportar_cmd.TabIndex = 10;
            this.exportar_cmd.Text = "Exportar";
            this.exportar_cmd.UseVisualStyleBackColor = true;
            this.exportar_cmd.Click += new System.EventHandler(this.exportar_cmd_Click);
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.Controls.Add(this.Panel1);
            this.FlowLayoutPanel1.Controls.Add(this.Panel2);
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(409, 70);
            this.FlowLayoutPanel1.TabIndex = 8;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.nombre_txt);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(253, 29);
            this.Panel1.TabIndex = 10;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(88, 6);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(154, 20);
            this.nombre_txt.TabIndex = 4;
            this.nombre_txt.TextChanged += new System.EventHandler(this.nombre_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar Nombre:";
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.Controls.Add(this.hasta_lbl);
            this.Panel2.Controls.Add(this.fechaHasta_dtp);
            this.Panel2.Controls.Add(this.desde_chk);
            this.Panel2.Controls.Add(this.fechaDesde_dtp);
            this.Panel2.Location = new System.Drawing.Point(3, 38);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(403, 29);
            this.Panel2.TabIndex = 11;
            // 
            // hasta_lbl
            // 
            this.hasta_lbl.AutoSize = true;
            this.hasta_lbl.Location = new System.Drawing.Point(252, 9);
            this.hasta_lbl.Name = "hasta_lbl";
            this.hasta_lbl.Size = new System.Drawing.Size(36, 13);
            this.hasta_lbl.TabIndex = 15;
            this.hasta_lbl.Text = "hasta:";
            // 
            // fechaHasta_dtp
            // 
            this.fechaHasta_dtp.CustomFormat = "";
            this.fechaHasta_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHasta_dtp.Location = new System.Drawing.Point(294, 6);
            this.fechaHasta_dtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaHasta_dtp.Name = "fechaHasta_dtp";
            this.fechaHasta_dtp.Size = new System.Drawing.Size(102, 20);
            this.fechaHasta_dtp.TabIndex = 14;
            this.fechaHasta_dtp.ValueChanged += new System.EventHandler(this.fechaHasta_dtp_ValueChanged);
            // 
            // desde_chk
            // 
            this.desde_chk.AutoSize = true;
            this.desde_chk.Location = new System.Drawing.Point(7, 8);
            this.desde_chk.Name = "desde_chk";
            this.desde_chk.Size = new System.Drawing.Size(118, 17);
            this.desde_chk.TabIndex = 10;
            this.desde_chk.Text = "Inicio turnos desde:";
            this.desde_chk.UseVisualStyleBackColor = true;
            this.desde_chk.CheckedChanged += new System.EventHandler(this.nombreODesde_checkedChangedOCambioDeTab);
            // 
            // fechaDesde_dtp
            // 
            this.fechaDesde_dtp.CustomFormat = "";
            this.fechaDesde_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesde_dtp.Location = new System.Drawing.Point(131, 6);
            this.fechaDesde_dtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaDesde_dtp.Name = "fechaDesde_dtp";
            this.fechaDesde_dtp.Size = new System.Drawing.Size(104, 20);
            this.fechaDesde_dtp.TabIndex = 9;
            this.fechaDesde_dtp.ValueChanged += new System.EventHandler(this.fechaDesde_dtp_ValueChanged);
            // 
            // turnos_dgv
            // 
            this.turnos_dgv.AllowUserToAddRows = false;
            this.turnos_dgv.AllowUserToDeleteRows = false;
            this.turnos_dgv.AllowUserToResizeRows = false;
            this.turnos_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.turnos_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.turnos_dgv.BackgroundColor = System.Drawing.Color.White;
            this.turnos_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.turnos_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.turnos_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnos_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.turnos_dgv.Location = new System.Drawing.Point(3, 73);
            this.turnos_dgv.MultiSelect = false;
            this.turnos_dgv.Name = "turnos_dgv";
            this.turnos_dgv.ReadOnly = true;
            this.turnos_dgv.RowHeadersVisible = false;
            this.turnos_dgv.Size = new System.Drawing.Size(521, 201);
            this.turnos_dgv.TabIndex = 9;
            // 
            // salir_cmd
            // 
            this.salir_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.salir_cmd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salir_cmd.Location = new System.Drawing.Point(12, 357);
            this.salir_cmd.Name = "salir_cmd";
            this.salir_cmd.Size = new System.Drawing.Size(89, 23);
            this.salir_cmd.TabIndex = 8;
            this.salir_cmd.Text = "Salir";
            this.salir_cmd.UseVisualStyleBackColor = true;
            // 
            // Configuracion_lkl
            // 
            this.Configuracion_lkl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Configuracion_lkl.AutoSize = true;
            this.Configuracion_lkl.Location = new System.Drawing.Point(476, 16);
            this.Configuracion_lkl.Name = "Configuracion_lkl";
            this.Configuracion_lkl.Size = new System.Drawing.Size(72, 13);
            this.Configuracion_lkl.TabIndex = 12;
            this.Configuracion_lkl.TabStop = true;
            this.Configuracion_lkl.Text = "Configuración";
            this.Configuracion_lkl.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // exportar_sfd
            // 
            this.exportar_sfd.Filter = "CSV files (*.csv)|*.CSV";
            this.exportar_sfd.FilterIndex = 2;
            this.exportar_sfd.RestoreDirectory = true;
            // 
            // AdministracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 392);
            this.Controls.Add(this.Configuracion_lkl);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.salir_cmd);
            this.Name = "AdministracionForm";
            this.Text = "Administracion";
            this.TabControl1.ResumeLayout(false);
            this.usuarios_tab.ResumeLayout(false);
            this.usuarios_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuario_dgv)).EndInit();
            this.turnos_tab.ResumeLayout(false);
            this.tabla_tlp.ResumeLayout(false);
            this.tabla_tlp.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnos_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage usuarios_tab;
        internal System.Windows.Forms.DataGridView usuario_dgv;
        internal System.Windows.Forms.Button modificar_cmd;
        internal System.Windows.Forms.Button eliminar_cmd;
        internal System.Windows.Forms.Button nuevo_cmd;
        internal System.Windows.Forms.Label explicacion_lbl;
        internal System.Windows.Forms.TabPage turnos_tab;
        internal System.Windows.Forms.TableLayoutPanel tabla_tlp;
        internal System.Windows.Forms.Button exportar_cmd;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox nombre_txt;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label hasta_lbl;
        internal System.Windows.Forms.DateTimePicker fechaHasta_dtp;
        private System.Windows.Forms.CheckBox desde_chk;
        internal System.Windows.Forms.DateTimePicker fechaDesde_dtp;
        internal System.Windows.Forms.DataGridView turnos_dgv;
        internal System.Windows.Forms.Button salir_cmd;
        private System.Windows.Forms.LinkLabel Configuracion_lkl;
        private System.Windows.Forms.SaveFileDialog exportar_sfd;
        private System.Windows.Forms.Label label1;
    }
}