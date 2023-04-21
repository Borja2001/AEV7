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
            nif = nif.Replace("-", "");//voy a ver
            MessageBox.Show(nif); 
            if (string.IsNullOrWhiteSpace(nif)) // solo sale error cuando  esta  vacio?
            {
                ok = false;
                erroresPPal.SetError(txtNIF, "INTRODUZCA NIF");
            }else
            {
                if (!UtilidadesNIF.Utilidad.ValidarLetraNIF(nif)) //pon un messagebox para veer si se escribe bien el nif
                {
                    ok = false;
                    erroresPPal.SetError(txtNIF, "NIF NO VÁLIDO");
                }
            } // Si meto el nif vacio y ejecuto no me entra en el primer if

            

            return ok;
        }



        #endregion

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
            if (DatosValidos())
            {
                pbImagenPpal.Visible = false;
                txtInformacion.Visible = true;
                btnVolver.Visible = true;
                //aqui mismo? si y hay que cerrarla despues de cada metodo o no se si podemos dejarla abierta hasta el final


                //creo que si, si cerramos el reader
                ConexionBD.AbrirConexion();
                if (Empleado.Existe(txtNIF.Text))
                {
                    DateTime? horaEntradaExistente = Empleado.HaEntrado(txtNIF.Text); //En teoría con el signo ? ya no habría problema
                    if (horaEntradaExistente == DateTime.MinValue)
                    {
                        int entradaCorrecta = Empleado.FicharEntrada(txtNIF.Text);
                        if (entradaCorrecta == 1)
                        {
                            string horaEntrada = DateTime.Now.ToString("HH:mm");
                            string mensaje = $"ENTRADA REALIZADA A LAS {horaEntrada} \n\r";
                            mensaje += Empleado.InformacionPersona(txtNIF.Text);

                            txtInformacion.Text = mensaje;
                        }
                        else
                        {
                            MessageBox.Show("Algo ha ido mal");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"El empleado con NIF {txtNIF.Text} ya ha realizado su entrada en la fecha: \n {horaEntradaExistente.Value.ToString("HH:mm")}", "Entrada previamente realizada");
                    }

                }
                else
                {
                    MessageBox.Show("El NIF introducido no se encuentra registrado entre nuestros empleados.", "Empleado no existe");
                }
                ConexionBD.CerrarConexion();

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
                pbImagenPpal.Visible = false;
                txtInformacion.Visible = true;
                btnVolver.Visible = true;
                ConexionBD.AbrirConexion();

                if (Empleado.Existe(txtNIF.Text))
                {
                    DateTime horaEntradaExistente = Empleado.HaEntrado(txtNIF.Text);
                    if (horaEntradaExistente != DateTime.MinValue)
                    {
                        int salidaCorrecta = Empleado.FicharSalida(txtNIF.Text);
                        if (salidaCorrecta == 1)
                        {
                            // Se ha realizado correctamente la salida en el fichaje
                            //Mostramos en el textbox Información del Empleado y la hora actual
                            string horaSalida = DateTime.Now.ToString("HH:mm");
                            string mensaje = $"SALIDA REALIZADA A LAS {horaSalida} \n\r";
                            mensaje += Empleado.InformacionPersona(txtNIF.Text);

                            txtInformacion.Text = mensaje;
                        }
                        else
                        {
                            MessageBox.Show("Algo ha ido mal");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"El empleado con NIF {txtNIF.Text} no ha realizado aún su entrada.", "Entrada no realizada");
                    }

                }
                else
                {
                    MessageBox.Show("El NIF introducido no se encuentra registrado entre nuestros empleados.", "Empleado no existe");
                }
                ConexionBD.CerrarConexion();

            }
        }

    }


}
