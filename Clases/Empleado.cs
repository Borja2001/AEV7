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


            return false;
        }
    }
}
