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
        public override int EliminarEmpleado(string nif)
        {

            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "DELETE FROM empleados WHERE nif like @nif;";
                cmd.Parameters.AddWithValue("@nif", nif);
                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        /*public override int AgregarEmpleado(Empleado em, bool administrador, string claveadmin) 
        {

            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Empleados (nif, nombre, apellidos, admin, clave) " +
                    "VALUES (@nif, @nombre, @apellidos, @admin, @clave)";

                
                cmd.Parameters.AddWithValue("@admin", administrador);
                cmd.Parameters.AddWithValue("@clave", claveadmin);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }*/

    }
}
