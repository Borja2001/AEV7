using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    internal class Fichaje
    {
        private string nif;
        private DateTime diaHoraEntrada;
        private DateTime horaSalida;

        public Fichaje(string nif)
        {
            diaHoraEntrada = DateTime.Today;
        }
        public static int FicharEntrada(string nif)
        {

            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Fichaje (nif_empl, dia_hora_entrada,dia_hora_salida) " +
                    "VALUES (@nif_empl, @entrada,null)";

                cmd.Parameters.AddWithValue("@nif_empl", nif);
                cmd.Parameters.AddWithValue("@entrada", Convert.ToDateTime(DateTime.Now));


                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }
        public static int FicharSalida(string nif)
        {

            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "update Fichaje set dia_hora_salida=NOW() where (nif_empl like " + "@nif_empl) and (dia_hora_salida is null)";

                cmd.Parameters.AddWithValue("@nif_empl", nif);
                // cmd.Parameters.AddWithValue("@salida", Convert.ToDateTime(DateTime.Now)); 
                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        public static DateTime HaEntrado(string nif)
        {
            //string consulta = string.Format("SELECT dia_hora_salida FROM FICHAJE WHERE NIF_empl LIKE ('{0}') and dia_hora_entrada like ( select Max('dia_hora_entrada') from fichajes)", nif);
            string consulta = string.Format("select dia_hora_entrada from fichaje where (nif_empl like ('{0}')) and (dia_hora_salida is null)", nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            DateTime fecha = DateTime.MinValue; // Se debe especificar un valor inicial para la variable fecha
            if (reader.Read()) // Se puede utilizar directamente el método Read() en vez de HasRows
            {
                fecha = reader.GetDateTime(0);
            }
            reader.Close();
            return fecha;

        }
    }
}
