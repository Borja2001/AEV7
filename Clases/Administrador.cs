using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    internal class Administrador : Empleado
    {
        private string clave;

        public Administrador(string nif, string nom, string ape,string clave) : base(nif,nom,ape)
        {
            this.clave = clave;
        }


        public static bool IniciarSesion(string clave, string nif)
        {
            string consulta = "SELECT clave FROM Empleados WHERE nif = @nif_empl";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("@nif_empl", nif); 
            MySqlDataReader reader = comando.ExecuteReader();
            
            string claveBD = "";
            if (reader.Read())
            {
                claveBD = reader.GetString(0);
            }
            reader.Close();

            return claveBD == clave;
        }

    }
}
