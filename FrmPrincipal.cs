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
using Mysqlx;

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
            dttFin.Visible = false;
            dttInicio.Visible = false;
            lblFechaFin.Visible= false;
            lblFechaInicio.Visible=false;
            btnConsultaPermanencia.Visible = false;

            dttFin.MinDate = dttInicio.Value;

        }

        #region VALIDACIONES

        private bool DatosValidos()
        {
            bool ok = true;

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();

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
                        else
                        {
                            if (!Empleado.Existe(nif))
                            {
                                ok = false;
                                erroresPPal.SetError(txtNIF, "EMPLEADO NO EXISTE");
                            }
                        }
                        
                    }

                }
                return ok;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return ok;

            }

            finally
            {
                ConexionBD.CerrarConexion();
            }

        }


        private bool DatosValidosAdmin()
        {
            bool ok = true;

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();

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

                        if (!Empleado.Existe(nif))
                        {
                            ok = false;
                            erroresPPal.SetError(txtNIF, "EMPLEADO NO EXISTE");
                        }

                        if (!Administrador.EsAdmin(nif))
                        {
                            ok = false;
                            erroresPPal.SetError(txtNIF, "NO ERES ADMINISTRADOR");
                        }
                    }
   

                }

                return ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return ok;
            }

            finally
            {
                ConexionBD.CerrarConexion();
            }
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
            if (DatosValidosAdmin())
            {

                FrmClaveAdmin clave1 = new FrmClaveAdmin(nif);

                clave1.StartPosition = FormStartPosition.Manual;
                clave1.Location = this.Location;

                clave1.ShowDialog();
            }
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
                        dttFin.Visible = false;
                        dttInicio.Visible = false;
                        lblFechaFin.Visible = false;
                        lblFechaInicio.Visible = false;
                        btnConsultaPermanencia.Visible = false;
                        txtInformacion.Visible = true;
                        txtPermanencia.Visible = false;
                        dgvPermanencia.Visible = false;
                        txtInformacion.BackColor = Color.White;
                        txtInformacion.ForeColor = Color.Black;

                        btnVolver.Visible = true;

                        string nif = txtNIF.Text;
                        nif = nif.Replace("-", "");

                        
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
                                string mensajeError = $"{Environment.NewLine} El empleado con NIF {nif} ya ha realizado su entrada en la fecha: \n {horaEntradaExistente.Value.ToString("g")}";
                                txtInformacion.BackColor = Color.Salmon;
                                txtInformacion.ForeColor = Color.White;
                                txtInformacion.Text = mensajeError;
                            }
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


            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            pbImagenPpal.Visible = true;
            txtInformacion.Visible = false;
            btnVolver.Visible = false;
            lblFechaFin.Visible = false;
            lblFechaInicio.Visible = false;
            dttFin.Visible = false;
            dttInicio.Visible = false;
            btnConsultaPermanencia.Visible = false;
            txtPermanencia.Visible=false;
            txtInformacion.BackColor = Color.White;
            txtInformacion.ForeColor = Color.Black;
            dgvPermanencia.Visible = false;
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
                        dttFin.Visible = false;
                        dttInicio.Visible = false;
                        lblFechaFin.Visible = false;
                        lblFechaInicio.Visible = false;
                        btnConsultaPermanencia.Visible = false;
                        txtPermanencia.Visible = false;
                        dgvPermanencia.Visible = false;
                        txtInformacion.BackColor = Color.White;
                        txtInformacion.ForeColor = Color.Black;
                        txtInformacion.Visible = true;
                        btnVolver.Visible = true;

                        string nif = txtNIF.Text;
                        nif = nif.Replace("-", "");


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
                            txtInformacion.BackColor = Color.Salmon;
                            txtInformacion.ForeColor = Color.White;
                            txtInformacion.Text = $"{Environment.NewLine}EL EMPLEADO CON NIF {nif} AÚN NO HA REALIZADO SU ENTRADA.";
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
                    dttFin.Visible = false;
                    dttInicio.Visible = false;
                    lblFechaFin.Visible = false;
                    lblFechaInicio.Visible = false;
                    btnConsultaPermanencia.Visible = false;
                    txtPermanencia.Visible = false;
                    dgvPermanencia.Visible = false;
                    txtInformacion.BackColor = Color.White;
                    txtInformacion.ForeColor = Color.Black;
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
            if (DatosValidos())
            {
                pbImagenPpal.Visible = false;
                txtInformacion.Visible = false;
                txtInformacion.BackColor = Color.White;
                txtInformacion.ForeColor = Color.Black;
                btnConsultaPermanencia.Visible = true;
                btnVolver.Visible = true;
                lblFechaInicio.Visible = true;
                lblFechaFin.Visible = true;
                dttInicio.Visible = true;
                dttFin.Visible = true;
            }
           
        }

        private void btnConsultaPermanencia_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();

                        DateTime fechaInicio = dttInicio.Value.Date;
                       
                        DateTime fechaFin = dttFin.Value;

                        string nif = txtNIF.Text;
                        nif = nif.Replace("-", "");

                       
                            List<Fichaje> listaPerm = Fichaje.Permanencia(nif, fechaInicio, fechaFin);

                            string totalHoras = Fichaje.HorasTotales(listaPerm);

                            string mensaje = $"{Environment.NewLine}FECHA INICIO: {fechaInicio.ToString("d")}{Environment.NewLine}FECHA FIN: {fechaFin.ToString("d")}";
                            mensaje += $"{Environment.NewLine}TOTAL: {totalHoras} HORAS";


                            dttInicio.Visible = false;
                            dttFin.Visible = false;
                            lblFechaFin.Visible = false;
                            lblFechaInicio.Visible = false;
                            btnConsultaPermanencia.Visible = false;
                            txtPermanencia.Visible = true;
                            txtInformacion.BackColor = Color.White;
                            txtInformacion.ForeColor = Color.Black;

                            txtPermanencia.Text = mensaje;

                            dgvPermanencia.Visible = true;

                            dgvPermanencia.AutoGenerateColumns = false;
                            dgvPermanencia.DataSource = Fichaje.Permanencia(nif, fechaInicio, fechaFin);
                        
                        
                        
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

        private void dttInicio_ValueChanged(object sender, EventArgs e)
        {
            dttFin.MinDate = dttInicio.Value;
        }
    }
}
    


