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
            this.SuspendLayout();
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(493, 24);
            this.txtNIF.Mask = "00000000-L";
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(337, 78);
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
            this.lblFechaHora.Location = new System.Drawing.Point(918, 48);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(79, 43);
            this.lblFechaHora.TabIndex = 3;
            this.lblFechaHora.Text = "___";
            // 
            // FrmPPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1406, 496);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtNIF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPPal";
            this.Text = "Fichaje Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNIF;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Timer Fecha_Hora;
        private System.Windows.Forms.Label lblFechaHora;
    }
}

