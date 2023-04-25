using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    internal class Fichaje
    {
        private string nif;
        private DateTime diaHoraEntrada;
        private DateTime diaHoraSalida;
        private TimeSpan duracion= TimeSpan.Zero;

         public string Nif { get { return nif; } }
         public DateTime DiaHoraEntrada { get { return diaHoraEntrada; } }
        public DateTime DiaHoraSalida { get { return diaHoraSalida; } }
        public TimeSpan Duracion { get { return duracion; } }



        public Fichaje(string nif)
        {
            diaHoraEntrada = DateTime.Today;
        }
        public Fichaje(string nif,DateTime fecha_entrada,DateTime fecha_salida, TimeSpan dur)
        {
            this.nif = nif;
            diaHoraEntrada = fecha_entrada;
            diaHoraSalida= fecha_salida;
            duracion = dur;
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

        public static List<Fichaje> Permanencia(string nif, DateTime fecha_inicial, DateTime fecha_final)
        {
            List<Fichaje> fichajes = new List<Fichaje>();
            string consulta = "SELECT dia_hora_entrada,dia_hora_salida FROM fichaje WHERE (nif_empl = @nif_empl) AND (dia_hora_entrada BETWEEN @fecha_inicial AND @fecha_final) and (dia_hora_salida is not null)";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("@nif_empl", nif);
            comando.Parameters.AddWithValue("@fecha_inicial", fecha_inicial);
            comando.Parameters.AddWithValue("@fecha_final", fecha_final);

            MySqlDataReader reader = comando.ExecuteReader();
            TimeSpan totalHoras = TimeSpan.Zero;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DateTime horaEntrada = reader.GetDateTime(0);
                    DateTime horaSalida = reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1);
                    TimeSpan duracion= horaSalida.Subtract(horaEntrada);
                    Fichaje fit = new Fichaje(null,horaEntrada,horaSalida,duracion);
                    fichajes.Add(fit);
                    totalHoras += duracion;
                    
                }
            }

            //string horasFormateadas = string.Format("{0:00}:{1:00}", (int)totalHoras.TotalHours, totalHoras.Minutes);
            reader.Close();

            return fichajes;
        }

        public static string HorasTotales(List<Fichaje> listFichajes)
        {
            TimeSpan totalHoras = TimeSpan.Zero;

            foreach (Fichaje item in listFichajes)
            {
                totalHoras += item.Duracion;
            }
            int horas = (int)totalHoras.TotalMinutes / 60;
            int minutos = (int)totalHoras.TotalMinutes % 60;
            string horasFormato = string.Format("{0:00}:{1:00}", horas, minutos);
            return horasFormato;
        }



        public static List<Fichaje> ListaFichajes()
        {
            List<Fichaje> todosLosFichajes = new List<Fichaje>();
            string consulta = "select * from Fichaje where dia_hora_salida is not null;";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DateTime horaEntrada = reader.GetDateTime(1);
                    DateTime horaSalida = reader.IsDBNull(2) ? DateTime.Now : reader.GetDateTime(2);
                    TimeSpan duracion = horaSalida.Subtract(horaEntrada);
                    Fichaje fit = new Fichaje(reader.GetString(0), horaEntrada, horaSalida,duracion);
                    todosLosFichajes.Add(fit);
                }
            }
            reader.Close();
            return todosLosFichajes;
        }

    }
}
