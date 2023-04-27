namespace AEV7
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.txtNIF = new System.Windows.Forms.MaskedTextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.Fecha_Hora = new System.Windows.Forms.Timer(this.components);
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.pbImagenPpal = new System.Windows.Forms.PictureBox();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.erroresPPal = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnConsultaPermanencia = new System.Windows.Forms.Button();
            this.dttInicio = new System.Windows.Forms.DateTimePicker();
            this.dttFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.txtPermanencia = new System.Windows.Forms.TextBox();
            this.dgvPermanencia = new System.Windows.Forms.DataGridView();
            this.diaHoraEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaHoraSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPpal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroresPPal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermanencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichajeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(493, 25);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNIF.Mask = "00000000-A";
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(357, 78);
            this.txtNIF.TabIndex = 0;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(28, 39);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(414, 55);
            this.lblNIF.TabIndex = 1;
            this.lblNIF.Text = "Introduzca NIF:";
            // 
            // Fecha_Hora
            // 
            this.Fecha_Hora.Enabled = true;
            this.Fecha_Hora.Interval = 1000;
            this.Fecha_Hora.Tick += new System.EventHandler(this.Fecha_Hora_Tick);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.BackColor = System.Drawing.Color.PowderBlue;
            this.lblFechaHora.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(953, 48);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(79, 43);
            this.lblFechaHora.TabIndex = 3;
            this.lblFechaHora.Text = "___";
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEntrada.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(1055, 159);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(301, 57);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalida.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(1055, 258);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(301, 57);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPresencia.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(1055, 361);
            this.btnPresencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(301, 57);
            this.btnPresencia.TabIndex = 6;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPermanencia.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(1055, 465);
            this.btnPermanencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(301, 57);
            this.btnPermanencia.TabIndex = 7;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.Thistle;
            this.btnMantenimiento.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(1055, 565);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(301, 57);
            this.btnMantenimiento.TabIndex = 8;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // pbImagenPpal
            // 
            this.pbImagenPpal.Image = global::AEV7.Properties.Resources.FLORIDA_UNIVERSITARIA;
            this.pbImagenPpal.Location = new System.Drawing.Point(39, 154);
            this.pbImagenPpal.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagenPpal.Name = "pbImagenPpal";
            this.pbImagenPpal.Size = new System.Drawing.Size(813, 468);
            this.pbImagenPpal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagenPpal.TabIndex = 9;
            this.pbImagenPpal.TabStop = false;
            // 
            // txtInformacion
            // 
            this.txtInformacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInformacion.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacion.Location = new System.Drawing.Point(39, 154);
            this.txtInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.ReadOnly = true;
            this.txtInformacion.Size = new System.Drawing.Size(812, 378);
            this.txtInformacion.TabIndex = 10;
            this.txtInformacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInformacion.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVolver.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(39, 565);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(813, 57);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // erroresPPal
            // 
            this.erroresPPal.ContainerControl = this;
            // 
            // btnConsultaPermanencia
            // 
            this.btnConsultaPermanencia.BackColor = System.Drawing.Color.PowderBlue;
            this.btnConsultaPermanencia.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPermanencia.Location = new System.Drawing.Point(39, 475);
            this.btnConsultaPermanencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaPermanencia.Name = "btnConsultaPermanencia";
            this.btnConsultaPermanencia.Size = new System.Drawing.Size(813, 57);
            this.btnConsultaPermanencia.TabIndex = 12;
            this.btnConsultaPermanencia.Text = "Consultar permanencia";
            this.btnConsultaPermanencia.UseVisualStyleBackColor = false;
            this.btnConsultaPermanencia.Visible = false;
            this.btnConsultaPermanencia.Click += new System.EventHandler(this.btnConsultaPermanencia_Click);
            // 
            // dttInicio
            // 
            this.dttInicio.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttInicio.Location = new System.Drawing.Point(416, 194);
            this.dttInicio.Name = "dttInicio";
            this.dttInicio.Size = new System.Drawing.Size(236, 46);
            this.dttInicio.TabIndex = 13;
            this.dttInicio.ValueChanged += new System.EventHandler(this.dttInicio_ValueChanged);
            // 
            // dttFin
            // 
            this.dttFin.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttFin.Location = new System.Drawing.Point(416, 340);
            this.dttFin.Name = "dttFin";
            this.dttFin.Size = new System.Drawing.Size(236, 46);
            this.dttFin.TabIndex = 14;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(87, 194);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(251, 38);
            this.lblFechaInicio.TabIndex = 15;
            this.lblFechaInicio.Text = "Fecha inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(87, 340);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(197, 38);
            this.lblFechaFin.TabIndex = 16;
            this.lblFechaFin.Text = "Fecha fin:";
            // 
            // txtPermanencia
            // 
            this.txtPermanencia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPermanencia.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermanencia.Location = new System.Drawing.Point(38, 154);
            this.txtPermanencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtPermanencia.Multiline = true;
            this.txtPermanencia.Name = "txtPermanencia";
            this.txtPermanencia.ReadOnly = true;
            this.txtPermanencia.Size = new System.Drawing.Size(812, 194);
            this.txtPermanencia.TabIndex = 17;
            this.txtPermanencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPermanencia.Visible = false;
            // 
            // dgvPermanencia
            // 
            this.dgvPermanencia.AutoGenerateColumns = false;
            this.dgvPermanencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPermanencia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPermanencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermanencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diaHoraEntradaDataGridViewTextBoxColumn,
            this.diaHoraSalidaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn});
            this.dgvPermanencia.DataSource = this.fichajeBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermanencia.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPermanencia.Location = new System.Drawing.Point(39, 356);
            this.dgvPermanencia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPermanencia.Name = "dgvPermanencia";
            this.dgvPermanencia.RowHeadersWidth = 51;
            this.dgvPermanencia.Size = new System.Drawing.Size(811, 201);
            this.dgvPermanencia.TabIndex = 18;
            this.dgvPermanencia.Visible = false;
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1459, 697);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dttFin);
            this.Controls.Add(this.dttInicio);
            this.Controls.Add(this.btnConsultaPermanencia);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.pbImagenPpal);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.dgvPermanencia);
            this.Controls.Add(this.txtPermanencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.Text = "Fichaje Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPpal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroresPPal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermanencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichajeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNIF;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Timer Fecha_Hora;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.PictureBox pbImagenPpal;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.ErrorProvider erroresPPal;
        private System.Windows.Forms.Button btnConsultaPermanencia;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dttFin;
        private System.Windows.Forms.DateTimePicker dttInicio;
        private System.Windows.Forms.TextBox txtPermanencia;
        private System.Windows.Forms.DataGridView dgvPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaHoraEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaHoraSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fichajeBindingSource;
    }
}

