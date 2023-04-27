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

        public string Clave { get { return clave; }}
        public Administrador(string nif, string nom, string ape,string clave) : base(nif,nom,ape)
        {
            this.clave = clave;
        }


        /// <summary>
        /// Método que valida el inicio de sesión de un administrador a el formulario de mantenimiento.
        /// </summary>
        /// <param name="clave">Se pasa por parámetro la clave introducida por el usuario</param>
        /// <param name="nif">Se pasa por parámetro el nif introducido por el usuario en el formulario anterior </param>
        /// <returns>Devuelve un booleano según la clave sea correcta o no</returns>
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



        /// <summary>
        /// Método que comprueba si el usuario es administrador o no.
        /// </summary>
        /// <param name="nif">Se comprueba mediante el nif del usuario</param>
        /// <returns>Devuelve un booleano según sea un usuario administrador o no</returns>
        public static bool EsAdmin(string nif)
        {
            string consulta = string.Format("SELECT * FROM Empleados WHERE NIF LIKE @nif and clave is not null");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("@nif", nif);
            MySqlDataReader reader = comando.ExecuteReader();

            int num = 0;

            while (reader.Read())
            {
                num++;
            }
            reader.Close();

            return num == 1;
        }



        /// <summary>
        /// Método que sobreescribe al método AgregarEmpleado de la clase padre Empleado. Se añade un nuevo empleado administrador a la base de datos.
        /// </summary>
        /// <returns>Devuelve el número de filas afectadas por la consulta en la base de datos</returns>
        public override int AgregarEmpleado() 
        {
            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Empleados (nif, nombre, apellidos, admin, clave) " +
                    "VALUES (@nif, @nombre, @apellidos, true, @clave)";

                cmd.Parameters.AddWithValue("@nif", this.nif);
                cmd.Parameters.AddWithValue("@nombre", this.nombre);
                cmd.Parameters.AddWithValue("@apellidos", this.apellidos);
                cmd.Parameters.AddWithValue("@clave", this.clave);


                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        /// <summary>
        /// Método que hace una consulta a la base de datos para recoger todos los usuarios que sean administradores.
        /// Después, los recoge todos en una lista.
        /// </summary>
        /// <returns>Devuelve la lista de administradores</returns>
        public static List<Administrador> ListaAdministradores()
        {
            List<Administrador> todosLosEmpl = new List<Administrador>();
            string consulta = "select * from Empleados where clave is not null;";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string clave = reader.GetString(4);
                    string clave1 = "";
                    for (int i = 0; i < clave.Length; i++)
                    {
                        clave1 += "*";
                    }

                    Administrador emp = new Administrador(reader.GetString(0), reader.GetString(1), reader.GetString(2),clave1);
                    todosLosEmpl.Add(emp);
                }
            }
            reader.Close();
            return todosLosEmpl;
        }

    }
}
