namespace AEV7
{
    partial class FrmPPal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPPal));
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
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPpal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(370, 20);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIF.Mask = "00000000-L";
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(269, 64);
            this.txtNIF.TabIndex = 0;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(21, 32);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(335, 45);
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
            this.lblFechaHora.Location = new System.Drawing.Point(715, 39);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(63, 36);
            this.lblFechaHora.TabIndex = 3;
            this.lblFechaHora.Text = "___";
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEntrada.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(791, 129);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(226, 46);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalida.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(791, 210);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(226, 46);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPresencia.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(791, 293);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(226, 46);
            this.btnPresencia.TabIndex = 6;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = false;
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPermanencia.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(791, 378);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(226, 46);
            this.btnPermanencia.TabIndex = 7;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.Thistle;
            this.btnMantenimiento.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(791, 459);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(226, 46);
            this.btnMantenimiento.TabIndex = 8;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // pbImagenPpal
            // 
            this.pbImagenPpal.Location = new System.Drawing.Point(29, 125);
            this.pbImagenPpal.Name = "pbImagenPpal";
            this.pbImagenPpal.Size = new System.Drawing.Size(610, 380);
            this.pbImagenPpal.TabIndex = 9;
            this.pbImagenPpal.TabStop = false;
            // 
            // FrmPPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1094, 566);
            this.Controls.Add(this.pbImagenPpal);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtNIF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPPal";
            this.Text = "Fichaje Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPpal)).EndInit();
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
    }
}

