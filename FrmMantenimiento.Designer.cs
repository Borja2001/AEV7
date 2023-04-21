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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimiento));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblInfoEmpleados = new System.Windows.Forms.Label();
            this.lblInfoFichajes = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbAltaEmpleados = new System.Windows.Forms.GroupBox();
            this.lblGestionEmpleados = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.chbAdministrador = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAltaEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Thistle;
            this.btnCerrar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(884, 502);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(164, 46);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(696, 502);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 46);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblInfoEmpleados
            // 
            this.lblInfoEmpleados.AutoSize = true;
            this.lblInfoEmpleados.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpleados.Location = new System.Drawing.Point(23, 6);
            this.lblInfoEmpleados.Name = "lblInfoEmpleados";
            this.lblInfoEmpleados.Size = new System.Drawing.Size(310, 24);
            this.lblInfoEmpleados.TabIndex = 11;
            this.lblInfoEmpleados.Text = "INFORMACIÓN DE EMPLEADOS:";
            // 
            // lblInfoFichajes
            // 
            this.lblInfoFichajes.AutoSize = true;
            this.lblInfoFichajes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFichajes.Location = new System.Drawing.Point(23, 293);
            this.lblInfoFichajes.Name = "lblInfoFichajes";
            this.lblInfoFichajes.Size = new System.Drawing.Size(298, 24);
            this.lblInfoFichajes.TabIndex = 12;
            this.lblInfoFichajes.Text = "INFORMACIÓN DE FICHAJES:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(27, 33);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(636, 228);
            this.dgvEmpleados.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 228);
            this.dataGridView1.TabIndex = 14;
            // 
            // gbAltaEmpleados
            // 
            this.gbAltaEmpleados.Controls.Add(this.txtNIF);
            this.gbAltaEmpleados.Controls.Add(this.txtNombre);
            this.gbAltaEmpleados.Controls.Add(this.txtApellidos);
            this.gbAltaEmpleados.Controls.Add(this.txtContraseña);
            this.gbAltaEmpleados.Controls.Add(this.chbAdministrador);
            this.gbAltaEmpleados.Controls.Add(this.lblContraseña);
            this.gbAltaEmpleados.Controls.Add(this.lblApellidos);
            this.gbAltaEmpleados.Controls.Add(this.lblNombre);
            this.gbAltaEmpleados.Controls.Add(this.lblNIF);
            this.gbAltaEmpleados.Controls.Add(this.btnEliminar);
            this.gbAltaEmpleados.Controls.Add(this.btnAgregar);
            this.gbAltaEmpleados.Controls.Add(this.lblGestionEmpleados);
            this.gbAltaEmpleados.Location = new System.Drawing.Point(696, 33);
            this.gbAltaEmpleados.Name = "gbAltaEmpleados";
            this.gbAltaEmpleados.Size = new System.Drawing.Size(352, 431);
            this.gbAltaEmpleados.TabIndex = 15;
            this.gbAltaEmpleados.TabStop = false;
            // 
            // lblGestionEmpleados
            // 
            this.lblGestionEmpleados.AutoSize = true;
            this.lblGestionEmpleados.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEmpleados.Location = new System.Drawing.Point(52, 16);
            this.lblGestionEmpleados.Name = "lblGestionEmpleados";
            this.lblGestionEmpleados.Size = new System.Drawing.Size(250, 24);
            this.lblGestionEmpleados.TabIndex = 16;
            this.lblGestionEmpleados.Text = "GESTIÓN DE EMPLEADOS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Thistle;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(216, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 46);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(31, 370);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 46);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(86, 72);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(50, 22);
            this.lblNIF.TabIndex = 19;
            this.lblNIF.Text = "NIF:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(57, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(27, 175);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(110, 22);
            this.lblApellidos.TabIndex = 21;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(17, 300);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(120, 22);
            this.lblContraseña.TabIndex = 22;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // chbAdministrador
            // 
            this.chbAdministrador.AutoSize = true;
            this.chbAdministrador.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAdministrador.Location = new System.Drawing.Point(73, 233);
            this.chbAdministrador.Name = "chbAdministrador";
            this.chbAdministrador.Size = new System.Drawing.Size(179, 26);
            this.chbAdministrador.TabIndex = 16;
            this.chbAdministrador.Text = "Administrador/a";
            this.chbAdministrador.UseVisualStyleBackColor = true;
            this.chbAdministrador.CheckedChanged += new System.EventHandler(this.chbAdministrador_CheckedChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(143, 299);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(178, 23);
            this.txtContraseña.TabIndex = 23;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(143, 175);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(178, 23);
            this.txtApellidos.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(143, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 23);
            this.txtNombre.TabIndex = 25;
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(143, 71);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(178, 23);
            this.txtNIF.TabIndex = 26;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1094, 566);
            this.Controls.Add(this.gbAltaEmpleados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.lblInfoFichajes);
            this.Controls.Add(this.lblInfoEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMantenimiento";
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAltaEmpleados.ResumeLayout(false);
            this.gbAltaEmpleados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblInfoEmpleados;
        private System.Windows.Forms.Label lblInfoFichajes;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbAltaEmpleados;
        private System.Windows.Forms.CheckBox chbAdministrador;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblGestionEmpleados;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
    }
}