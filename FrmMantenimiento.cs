using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        #region VALIDACIONES
        private bool DatosValidosAñadir()
        {
            bool ok = true;
            errorMantenimiento.Clear();
            string nif = txtNIF.Text;            

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    if (Empleado.Existe(nif))
                    {
                        ok = false;
                        errorMantenimiento.SetError(txtNIF, "EMPLEADO YA EXISTE");
                    }
                    ConexionBD.CerrarConexion();
                }

                if (string.IsNullOrWhiteSpace(nif))
                {
                    ok = false;
                    errorMantenimiento.SetError(txtNIF, "INTRODUZCA NIF");
                }
                else
                {
                    if (!UtilidadesNIF.Utilidad.ValidarLetraNIF(nif))
                    {
                        ok = false;
                        errorMantenimiento.SetError(txtNIF, "NIF NO VÁLIDO");
                    }
                }

                if (txtNombre.Text == "")
                {
                    ok = false;
                    errorMantenimiento.SetError(txtNombre, "INTRODUZCA NOMBRE");
                }

                if (txtApellidos.Text == "")
                {
                    ok = false;
                    errorMantenimiento.SetError(txtApellidos, "INTRODUZCA APELLIDOS");
                }

                if (chbAdministrador.Checked == true && txtContrasenya.Text == "")
                {
                    ok = false;
                    errorMantenimiento.SetError(txtContrasenya, "INTRODUZCA CONTRASEÑA");
                }
                ConexionBD.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return ok;
        }

        private bool DatosValidosEliminar()
        {
            bool ok = true;
            errorMantenimiento.Clear();
            string nif = txtNIF.Text;

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    if (!Empleado.Existe(nif))
                    {
                        ok = false;
                        errorMantenimiento.SetError(txtNIF, "EMPLEADO NO EXISTE");
                    }
                    ConexionBD.CerrarConexion();
                }

                if (string.IsNullOrWhiteSpace(nif))
                {
                    ok = false;
                    errorMantenimiento.SetError(txtNIF, "INTRODUZCA NIF");
                }
                else
                {
                    if (!UtilidadesNIF.Utilidad.ValidarLetraNIF(nif))
                    {
                        ok = false;
                        errorMantenimiento.SetError(txtNIF, "NIF NO VÁLIDO");
                    }
                }
                ConexionBD.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return ok;
        }


        #endregion

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            CargarListaEmpleados();

            CargarListaFichajes();


        }

        private void RestablecerValores()
        {
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtContrasenya.Text = string.Empty;
            chbAdministrador.Checked = false;
        }


        private void CargarListaEmpleados()
        {
            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    List<Empleado> lista = Empleado.ListaEmpleados();
                    List<Administrador> listaAdmin = Administrador.ListaAdministradores();

                    dgvAdmin.DataSource = listaAdmin;
                    dgvEmpleados.DataSource = lista;
                }
                ConexionBD.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }

        private void CargarListaFichajes()
        {
            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();

                    dgvFichajes.DataSource = Fichaje.ListaFichajes();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdministrador.Checked == true)
            {
                txtContrasenya.Enabled = true;
            }else
            {
                txtContrasenya.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (DatosValidosAñadir())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        string nif = txtNIF.Text;
                        

                        if (chbAdministrador.Checked == true)
                        {
                            Administrador emp = new Administrador(nif, txtNombre.Text, txtApellidos.Text, txtContrasenya.Text);
                            emp.AgregarEmpleado();
                            

                        }
                        else
                        {
                            Empleado emp = new Empleado(nif, txtNombre.Text, txtApellidos.Text);
                            emp.AgregarEmpleado();

                        }
                        Log.GuardarDatosModificar(nif, true);
                        RestablecerValores();
                        ConexionBD.CerrarConexion();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }

                CargarListaEmpleados();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DatosValidosEliminar())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        string nif = txtNIF.Text;

                        Empleado.EliminarEmpleado(nif);
                        Fichaje.FicharSalida(nif);
                        Log.GuardarDatosModificar(nif, false);

                    }
                    RestablecerValores();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }
                CargarListaEmpleados();

            }
        }

        
    }
}
