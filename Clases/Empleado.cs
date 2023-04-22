using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static AEV7.ConexionBD;

namespace AEV7
{
    internal class Empleado
    {
        protected string nif;
        protected string nombre;
        protected string apellidos;

        public Empleado(string nif, string nom, string ape)
        {
            this.nif = nif;
            nombre = nom;
            apellidos = ape;
        }

        public static bool Existe(string nif)
        {
            string consulta = string.Format("SELECT * FROM Empleados WHERE NIF LIKE ('{0}')", nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            int num = 0;

            while (reader.Read())
            {
                num++;
            }
            reader.Close();

            return num == 1;
        }

        


        public static int AgregarEmpleado(Empleado em, bool administrador, string claveadmin)
        {

            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Empleados (nif, nombre, apellidos, admin, clave) " +
                    "VALUES (@nif, @nombre, @apellidos, @admin, @clave)";

                cmd.Parameters.AddWithValue("@nif", em.nif);
                cmd.Parameters.AddWithValue("@nombre", em.nombre);
                cmd.Parameters.AddWithValue("@apellidos", em.apellidos);
                cmd.Parameters.AddWithValue("@admin", administrador);
                cmd.Parameters.AddWithValue("@clave", claveadmin);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }


        public static string InformacionPersona(string nif)
        {
            string consulta = "SELECT * FROM Empleados WHERE nif = @nif_empl";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.Add("@nif_empl", MySqlDbType.VarChar).Value = nif;
            MySqlDataReader reader = comando.ExecuteReader();
            string informacion = "";

            if (reader.Read())
            {
                informacion = "\n\rNIF: " + reader.GetString(0) + "\n\rNombre: " + reader.GetString(1) + "\n\rApellidos: " + reader.GetString(2) + "\n\rAdministrador: " + reader.GetBoolean(3).ToString();
            }

            reader.Close();
            return informacion;
        }




        public static string Permanencia(string nif, DateTime fecha_inicial, DateTime fecha_final)
        {
            string consulta = "SELECT dia_hora_entrada, dia_hora_salida FROM fichaje WHERE nif_empl = @nif_empl AND fecha BETWEEN @fecha_inicial AND @fecha_final";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("@nif_empl", nif);
            comando.Parameters.AddWithValue("@fecha_inicial", fecha_inicial);
            comando.Parameters.AddWithValue("@fecha_final", fecha_final);

            MySqlDataReader reader = comando.ExecuteReader();
            TimeSpan totalHoras=  TimeSpan.Zero;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DateTime horaEntrada = reader.GetDateTime(0);
                    DateTime horaSalida = reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1);
                    totalHoras +=   horaEntrada.Subtract(horaSalida);
                }
            }

            string horasFormateadas = string.Format("{0:00}:{1:00}", (int)totalHoras.TotalHours, totalHoras.Minutes);
            reader.Close();

            return horasFormateadas;


            
        }

    }
}
