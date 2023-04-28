using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AEV7
{
    internal class Log
    {
        public Log() { }

  



        /// <summary>
        /// Método que guarda datos de fichaje de entrada o de salida en un fichero Log.
        /// </summary>
        /// <param name="nif">El nif del empleado</param>
        /// <param name="entrada">true=entrada</param>
        public static void GuardarDatosFichaje(string nif, bool entrada)
        {
            List<string> registro = RecuperarDatos();
            string ruta = NombreFichero();
            StreamWriter fichero = new StreamWriter(ruta);
            if (entrada)
            {
                registro.Add(DateTime.Now.ToString() + " - Fichaje de entrada --> Nif: " + nif);
            }else registro.Add(DateTime.Now.ToString() + " - Fichaje de salida --> Nif: " + nif);
            
            foreach (string emp in registro)
            {
                fichero.WriteLine(emp);
            }
            fichero.Close();
        }

        

        /// <summary>
        /// Método que guarda en un fichero Log los registros de acceso al formulario de mantenimientp
        /// </summary>
        /// <param name="nif">string</param>
        public static void GuardarDatosAcceso(string nif)
        {
            List<string> registro = RecuperarDatos();
            string ruta = NombreFichero();
            StreamWriter fichero = new StreamWriter(ruta);
            registro.Add(DateTime.Now.ToString() + " - Administrador accede a mantenimiento --> Nif: " + nif);
            foreach (string emp in registro)
            {
                fichero.WriteLine(emp);
            }
            fichero.Close();
        }



        /// <summary>
        /// Método que guarda datos cada vez que se añade o elimina un usuario. 
        /// </summary>
        /// <param name="nif">string</param>
        /// <param name="crear">true=crear</param>
        public static void GuardarDatosModificar(string nif, bool crear)
        {
            List<string> registro = RecuperarDatos();
            string ruta = NombreFichero();
            StreamWriter fichero = new StreamWriter(ruta);
            
            
            if (crear)
            {
                registro.Add(DateTime.Now.ToString() + " - Usuario añadido --> Nif: " + nif );
            }
            else
            {
                registro.Add(DateTime.Now.ToString() + " - Usuario eliminado --> Nif: " + nif );

            }
            foreach (string emp in registro)
            {
                fichero.WriteLine(emp);
            }
            fichero.Close();
        }
        
        /// <summary>
        /// Recupera los datos del fichero para que no se pierdan al modificarlo
        /// </summary>
        /// <returns>El interior del fichero</returns>
        private static List<string> RecuperarDatos()
        {
            string ruta = NombreFichero();
            string linea = "";
            List<string> texto = new List<string>();
            StreamReader fichero;

            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), ruta)))
            {
                fichero = new StreamReader(ruta);
                while ((linea = fichero.ReadLine()) != null)
                {
                    texto.Add(linea);
                }
                fichero.Close();
            }
            return texto;
        }


        /// <summary>
        /// Método que guarda el nombre del fichero Log con la fecha actual.
        /// </summary>
        /// <returns>Retorna el nombre del fichero</returns>
        private static string NombreFichero()
        {
            string fit = DateTime.Today.ToString("yyyy-MM-dd") + "log.txt";
            return fit;
        }

    }
}
