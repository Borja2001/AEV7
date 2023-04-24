using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7
{
    public partial class FrmClaveAdmin : Form
    {
        private string nif;
        public FrmClaveAdmin(string nif)
        {
            this.nif = nif;
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    if (Administrador.IniciarSesion(txtClave.Text, nif))
                    {
                        FrmMantenimiento mantenimiento1 = new FrmMantenimiento();

                        mantenimiento1.StartPosition = FormStartPosition.Manual;
                        mantenimiento1.Location = this.Location;
                        mantenimiento1.ShowDialog();
                        ConexionBD.CerrarConexion();

                        this.Close();
                        this.Dispose();
                    }else
                    {
                        ConexionBD.CerrarConexion();

                        lblError.Text = "CLAVE INCORRECTA";
                        lblError.Visible = true;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                ConexionBD.CerrarConexion();

            }



        }
    }
}
