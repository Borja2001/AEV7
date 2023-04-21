using System;
using System.Collections.Generic;
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

        public bool Existe(string nif)
        {
            string consulta = string.Format("SELECT * FROM EMPLEADO WHERE NIF LIKE ('{0}')",nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            int num = 0;

            while (reader.Read())
            {
                num++;
            }
            reader.Close();
            
            return num==1;
        }

        public bool HaEntrado(string nif)
        {
            string consulta = string.Format("SELECT dia_hora_salida FROM FICHAJE WHERE NIF_empl LIKE ('{0}') and dia_hora_entrada like ( select Max('dia_hora_entrada') from fichajes)", nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            return false;
        }
    }
}
