namespace AEV7
{
    partial class FrmMantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimiento));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblInfoEmpleados = new System.Windows.Forms.Label();
            this.lblInfoFichajes = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.gbAltaEmpleados = new System.Windows.Forms.GroupBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.chbAdministrador = new System.Windows.Forms.CheckBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblGestionEmpleados = new System.Windows.Forms.Label();
            this.nifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaHoraEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaHoraSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nifDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorMantenimiento = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            this.gbAltaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fichajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Thistle;
            this.btnCerrar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(928, 618);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(219, 57);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1178, 618);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(219, 57);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblInfoEmpleados
            // 
            this.lblInfoEmpleados.AutoSize = true;
            this.lblInfoEmpleados.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpleados.Location = new System.Drawing.Point(31, 7);
            this.lblInfoEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoEmpleados.Name = "lblInfoEmpleados";
            this.lblInfoEmpleados.Size = new System.Drawing.Size(389, 32);
            this.lblInfoEmpleados.TabIndex = 11;
            this.lblInfoEmpleados.Text = "INFORMACIÓN DE EMPLEADOS:";
            // 
            // lblInfoFichajes
            // 
            this.lblInfoFichajes.AutoSize = true;
            this.lblInfoFichajes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFichajes.Location = new System.Drawing.Point(31, 361);
            this.lblInfoFichajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoFichajes.Name = "lblInfoFichajes";
            this.lblInfoFichajes.Size = new System.Drawing.Size(374, 32);
            this.lblInfoFichajes.TabIndex = 12;
            this.lblInfoFichajes.Text = "INFORMACIÓN DE FICHAJES:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoGenerateColumns = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nifDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn});
            this.dgvEmpleados.DataSource = this.empleadoBindingSource2;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.Location = new System.Drawing.Point(36, 41);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.Size = new System.Drawing.Size(848, 281);
            this.dgvEmpleados.TabIndex = 13;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.AutoGenerateColumns = false;
            this.dgvFichajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFichajes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nifDataGridViewTextBoxColumn,
            this.diaHoraEntradaDataGridViewTextBoxColumn,
            this.diaHoraSalidaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn});
            this.dgvFichajes.DataSource = this.fichajeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFichajes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFichajes.Location = new System.Drawing.Point(36, 394);
            this.dgvFichajes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.RowHeadersWidth = 51;
            this.dgvFichajes.Size = new System.Drawing.Size(848, 281);
            this.dgvFichajes.TabIndex = 14;
            // 
            // gbAltaEmpleados
            // 
            this.gbAltaEmpleados.Controls.Add(this.txtNIF);
            this.gbAltaEmpleados.Controls.Add(this.txtNombre);
            this.gbAltaEmpleados.Controls.Add(this.txtApellidos);
            this.gbAltaEmpleados.Controls.Add(this.txtContrasenya);
            this.gbAltaEmpleados.Controls.Add(this.chbAdministrador);
            this.gbAltaEmpleados.Controls.Add(this.lblContraseña);
            this.gbAltaEmpleados.Controls.Add(this.lblApellidos);
            this.gbAltaEmpleados.Controls.Add(this.lblNombre);
            this.gbAltaEmpleados.Controls.Add(this.lblNIF);
            this.gbAltaEmpleados.Controls.Add(this.btnEliminar);
            this.gbAltaEmpleados.Controls.Add(this.btnAgregar);
            this.gbAltaEmpleados.Controls.Add(this.lblGestionEmpleados);
            this.gbAltaEmpleados.Location = new System.Drawing.Point(928, 41);
            this.gbAltaEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.gbAltaEmpleados.Name = "gbAltaEmpleados";
            this.gbAltaEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.gbAltaEmpleados.Size = new System.Drawing.Size(469, 530);
            this.gbAltaEmpleados.TabIndex = 15;
            this.gbAltaEmpleados.TabStop = false;
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(191, 87);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(236, 27);
            this.txtNIF.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(191, 153);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 27);
            this.txtNombre.TabIndex = 25;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(191, 215);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(236, 27);
            this.txtApellidos.TabIndex = 24;
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenya.Location = new System.Drawing.Point(191, 368);
            this.txtContrasenya.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(236, 27);
            this.txtContrasenya.TabIndex = 23;
            // 
            // chbAdministrador
            // 
            this.chbAdministrador.AutoSize = true;
            this.chbAdministrador.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAdministrador.Location = new System.Drawing.Point(97, 287);
            this.chbAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.chbAdministrador.Name = "chbAdministrador";
            this.chbAdministrador.Size = new System.Drawing.Size(229, 32);
            this.chbAdministrador.TabIndex = 16;
            this.chbAdministrador.Text = "Administrador/a";
            this.chbAdministrador.UseVisualStyleBackColor = true;
            this.chbAdministrador.CheckedChanged += new System.EventHandler(this.chbAdministrador_CheckedChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(23, 369);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(155, 28);
            this.lblContraseña.TabIndex = 22;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(36, 215);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(142, 28);
            this.lblApellidos.TabIndex = 21;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(76, 154);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 28);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(115, 89);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(64, 28);
            this.lblNIF.TabIndex = 19;
            this.lblNIF.Text = "NIF:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(41, 455);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 57);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Thistle;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(288, 455);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 57);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblGestionEmpleados
            // 
            this.lblGestionEmpleados.AutoSize = true;
            this.lblGestionEmpleados.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEmpleados.Location = new System.Drawing.Point(69, 20);
            this.lblGestionEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionEmpleados.Name = "lblGestionEmpleados";
            this.lblGestionEmpleados.Size = new System.Drawing.Size(314, 32);
            this.lblGestionEmpleados.TabIndex = 16;
            this.lblGestionEmpleados.Text = "GESTIÓN DE EMPLEADOS";
            // 
            // nifDataGridViewTextBoxColumn
            // 
            this.nifDataGridViewTextBoxColumn.DataPropertyName = "Nif";
            this.nifDataGridViewTextBoxColumn.HeaderText = "Nif";
            this.nifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nifDataGridViewTextBoxColumn.Name = "nifDataGridViewTextBoxColumn";
            this.nifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaHoraEntradaDataGridViewTextBoxColumn
            // 
            this.diaHoraEntradaDataGridViewTextBoxColumn.DataPropertyName = "DiaHoraEntrada";
            this.diaHoraEntradaDataGridViewTextBoxColumn.HeaderText = "DiaHoraEntrada";
            this.diaHoraEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaHoraEntradaDataGridViewTextBoxColumn.Name = "diaHoraEntradaDataGridViewTextBoxColumn";
            this.diaHoraEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaHoraSalidaDataGridViewTextBoxColumn
            // 
            this.diaHoraSalidaDataGridViewTextBoxColumn.DataPropertyName = "DiaHoraSalida";
            this.diaHoraSalidaDataGridViewTextBoxColumn.HeaderText = "DiaHoraSalida";
            this.diaHoraSalidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaHoraSalidaDataGridViewTextBoxColumn.Name = "diaHoraSalidaDataGridViewTextBoxColumn";
            this.diaHoraSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fichajeBindingSource
            // 
            this.fichajeBindingSource.DataSource = typeof(AEV7.Fichaje);
            // 
            // nifDataGridViewTextBoxColumn1
            // 
            this.nifDataGridViewTextBoxColumn1.DataPropertyName = "Nif";
            this.nifDataGridViewTextBoxColumn1.HeaderText = "Nif";
            this.nifDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nifDataGridViewTextBoxColumn1.Name = "nifDataGridViewTextBoxColumn1";
            this.nifDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadoBindingSource2
            // 
            this.empleadoBindingSource2.DataSource = typeof(AEV7.Empleado);
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataSource = typeof(AEV7.Empleado);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(AEV7.Empleado);
            // 
            // errorMantenimiento
            // 
            this.errorMantenimiento.ContainerControl = this;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1459, 697);
            this.Controls.Add(this.gbAltaEmpleados);
            this.Controls.Add(this.dgvFichajes);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.lblInfoFichajes);
            this.Controls.Add(this.lblInfoEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            this.gbAltaEmpleados.ResumeLayout(false);
            this.gbAltaEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fichajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblInfoEmpleados;
        private System.Windows.Forms.Label lblInfoFichajes;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvFichajes;
        private System.Windows.Forms.GroupBox gbAltaEmpleados;
        private System.Windows.Forms.CheckBox chbAdministrador;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblGestionEmpleados;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaHoraEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaHoraSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fichajeBindingSource;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadoBindingSource2;
        private System.Windows.Forms.ErrorProvider errorMantenimiento;
    }
}