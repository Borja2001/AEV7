using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesNIF;
using System.Windows.Forms;

namespace AEV7
{
    public partial class FrmPPal : Form
    {
        public FrmPPal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("G");

        }

        private void Fecha_Hora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("G");
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            FrmMantenimiento mantenimiento1 = new FrmMantenimiento();

            mantenimiento1.StartPosition = FormStartPosition.Manual;
            mantenimiento1.Location = this.Location;
            mantenimiento1.Size = this.Size;

            mantenimiento1.ShowDialog();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            pbImagenPpal.Visible = false;
            txtInformacion.Visible = true;
            btnVolver.Visible = true;
        }
    }
}
