using Mysqlx;
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

        #region VALIDACIONES

        private bool DatosValidos()
        {
            bool ok = false;

            try
            {

                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();

                    if (Administrador.IniciarSesion(txtClave.Text, nif))
                    {
                        ok = true;

                    }else
                    {
                        ok = false;
                        errorAccesoAdmin.SetError(txtClave, "CLAVE INCORRECTA");

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
            return ok;
        }


        #endregion
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        FrmMantenimiento mantenimiento1 = new FrmMantenimiento();
                        Log.GuardarDatosAcceso(this.nif);
                        ConexionBD.CerrarConexion();
                        mantenimiento1.StartPosition = FormStartPosition.Manual;
                        mantenimiento1.Location = this.Location;

                        mantenimiento1.ShowDialog();

                        this.Close();
                        this.Dispose();
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
}
