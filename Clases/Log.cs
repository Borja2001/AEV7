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

        /*
        public static void GuardarDatos(int id, int eleccion)
        {
            List<string> registro = RecuperarDatos();
            string ruta = NombreFichero();

            StreamWriter fichero = new StreamWriter(ruta);
            if (eleccion == 1)
                registro.Add(DateTime.Now.ToString() + " - Eliminado un usuario con Id: " + id);
            else
                registro.Add(DateTime.Now.ToString() + " - Insertando/Modificando un usuario con Id: " + id);

            foreach (string emp in registro)
            {
                fichero.WriteLine(emp);
            }
            fichero.Close();
        }*/
        public static void GuardarDatos(string nombre, DateTime horaEntrada)
        {
            List<string> registro = RecuperarDatos();
            string ruta = "empleados.txt";
            StreamWriter fichero = new StreamWriter(ruta);
            registro.Add(DateTime.Now.ToString() + " - Entrando --> Nombre: " + nombre + " -- Hora entrada:  " + horaEntrada);
            foreach (string emp in registro)
            {
                fichero.WriteLine(emp);
            }
            fichero.Close();
        }
        public static void GuardarDatos(string nombre, DateTime horaEntrada, DateTime horaSalida)
        {
            List<string> registro = RecuperarDatos();
            string ruta = "empleados.txt";
            StreamWriter fichero = new StreamWriter(ruta);
            registro.Add(DateTime.Now.ToString() + " - Saliendo --> Nombre: " + nombre + " -- Hora entrada:  " + horaEntrada + " -- Hora salida:  " + horaSalida);
            foreach (string emp in registro)
            {
                fichero.WriteLine(emp);
            }
            fichero.Close();
        }/*
        public static void GuardarDatos(string nombreAdministrador, DateTime hora, string nombreEmp)
        {
            List<string> registro = RecuperarDatos();
            string ruta = "empleados.txt";
            StreamWriter fichero = new StreamWriter(ruta);
            registro.Add(DateTime.Now.ToString() + " - Creando --> Nombre: " + nombreAdministrador + " -- Hora entrada:  " + horaEntrada + " -- Hora salida:  " + horaSalida);
            foreach (string emp in registro)
            {
                fichero.WriteLine(emp);
            }
            fichero.Close();
        }
        */
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

        private static string NombreFichero()
        {
            string fit = DateTime.Today.ToString("yyyy-MM-dd") + "log.txt";
            return fit;
        }

    }
}
