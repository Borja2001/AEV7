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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("G");

        }

        #region VALIDACIONES

        private bool DatosValidos()
        {
            bool ok = true;
            erroresPPal.Clear();

            string nif = txtNIF.Text;
            nif = nif.Replace("-", "");
            if (string.IsNullOrWhiteSpace(nif))
            {
                ok = false;
                erroresPPal.SetError(txtNIF, "INTRODUZCA NIF");
            }
            else
            {
                if (!UtilidadesNIF.Utilidad.ValidarLetraNIF(nif))
                {
                    ok = false;
                    erroresPPal.SetError(txtNIF, "NIF NO VÁLIDO");
                }
            }



            return ok;
        }



        #endregion

        private void Fecha_Hora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("G");
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            string nif = txtNIF.Text;
            nif = nif.Replace("-", "");

            FrmClaveAdmin clave1 = new FrmClaveAdmin(nif);

            clave1.StartPosition = FormStartPosition.Manual;
            clave1.Location = this.Location;

            clave1.ShowDialog();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();

                        pbImagenPpal.Visible = false;
                        txtInformacion.Visible = true;
                        btnVolver.Visible = true;

                        string nif = txtNIF.Text;
                        nif = nif.Replace("-", "");

                        if (Empleado.Existe(nif))
                        {
                            DateTime? horaEntradaExistente = Fichaje.HaEntrado(nif); //En teoría con el signo ? ya no habría problema
                            if (horaEntradaExistente == DateTime.MinValue)
                            {
                                int entradaCorrecta = Fichaje.FicharEntrada(nif);
                                if (entradaCorrecta == 1)
                                {
                                    string horaEntrada = DateTime.Now.ToString("HH:mm");
                                    string infoPersona = Empleado.InformacionPersona(nif);

                                    string mensaje = $"{Environment.NewLine}ENTRADA REALIZADA A LAS {horaEntrada} {Environment.NewLine}";
                                    mensaje += infoPersona;
                                    txtInformacion.Text = mensaje;
                                }
                                else
                                {
                                    MessageBox.Show("Algo ha ido mal");
                                }
                            }
                            else
                            {
                                string mensajeError = $"El empleado con NIF {nif} ya ha realizado su entrada en la fecha: \n {horaEntradaExistente.Value.ToString("HH:mm")}";
                                txtInformacion.Text = mensajeError;

                                MessageBox.Show(mensajeError, "Entrada previamente realizada");
                            }

                        }
                        else
                        {
                            MessageBox.Show("El NIF introducido no se encuentra registrado entre nuestros empleados.", "Empleado no existe");
                        }
                        ConexionBD.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("El NIF introducido no se encuentra registrado entre nuestros empleados.", "Empleado no existe");
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
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            pbImagenPpal.Visible = true;
            txtInformacion.Visible = false;
            btnVolver.Visible = false;
        }


        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {

                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        pbImagenPpal.Visible = false;
                        txtInformacion.Visible = true;
                        btnVolver.Visible = true;

                        string nif = txtNIF.Text;
                        nif = nif.Replace("-", "");

                        if (Empleado.Existe(nif))
                        {
                            DateTime horaEntradaExistente = Fichaje.HaEntrado(nif);
                            if (horaEntradaExistente != DateTime.MinValue)
                            {
                                int salidaCorrecta = Fichaje.FicharSalida(nif);
                                if (salidaCorrecta == 1)
                                {
                                    // Se ha realizado correctamente la salida en el fichaje
                                    //Mostramos en el textbox Información del Empleado y la hora actual
                                    string horaSalida = DateTime.Now.ToString("HH:mm");
                                    string infoPersona = Empleado.InformacionPersona(nif);
                                    string mensaje = $"{Environment.NewLine}SALIDA REALIZADA A LAS {horaSalida} {Environment.NewLine}";
                                    mensaje += infoPersona;

                                    txtInformacion.Text = mensaje;
                                }
                                else
                                {
                                    MessageBox.Show("Algo ha ido mal");
                                }
                            }
                            else
                            {
                                string mensajeError = $"El empleado con NIF {nif} no ha realizado aún su entrada.";
                                txtInformacion.Text = mensajeError;
                                MessageBox.Show(mensajeError, "Entrada no realizada");
                            }

                        }
                        else
                        {
                            MessageBox.Show("El NIF introducido no se encuentra registrado entre nuestros empleados.", "Empleado no existe");
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

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();

                    pbImagenPpal.Visible = false;
                    txtInformacion.Visible = true;
                    btnVolver.Visible = true;

                    string mensaje = Empleado.InformacionPresencia();
                    txtInformacion.Text = mensaje;
                }

                ConexionBD.CerrarConexion(); // si esta abajo se necesita? La verdad es que no lo tengo claro voy a ejecutar
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

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            /*
            if (DatosValidos())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();

                        pbImagenPpal.Visible = false;
                        txtInformacion.Visible = true;
                        btnVolver.Visible = true;

                        string nif = txtNIF.Text;
                        nif = nif.Replace("-", "");

                        if (Empleado.Existe(nif))
                        {
                            DateTime? horaEntradaExistente = Fichaje.HaEntrado(nif); //En teoría con el signo ? ya no habría problema
                            if (horaEntradaExistente == DateTime.MinValue)
                            {
                                int entradaCorrecta = Fichaje.P(nif);
                                if (entradaCorrecta == 1)
                                {
                                   // string numeroHoras = Fichaje.Permanencia(nif,fecha_inicial,fecha_final);
                                    //txtInformacion.Text = mensaje;
                                    //por aqui habra errores 
                                    //espera, lo comento porque necesito ejecutar vale
                                }
                                else    
                                {
                                    MessageBox.Show("Algo ha ido mal");
                                }
                            }
                            else
                            {
                                string mensajeError = $"El empleado con NIF {nif} ya ha realizado su entrada en la fecha: \n {horaEntradaExistente.Value.ToString("HH:mm")}";
                                txtInformacion.Text = mensajeError;

                                MessageBox.Show(mensajeError, "Entrada previamente realizada");
                            }

                        }
                        else
                        {
                            MessageBox.Show("El NIF introducido no se encuentra registrado entre nuestros empleados.", "Empleado no existe");
                        }
                        ConexionBD.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("El NIF introducido no se encuentra registrado entre nuestros empleados.", "Empleado no existe");
                    }
                    ConexionBD.Conexion.Close();

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
        }*/
        }

    }
}

