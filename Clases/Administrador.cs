﻿using MySql.Data.MySqlClient;
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
        public static bool EsAdmin(string nif)
        {
            string consulta = string.Format("SELECT * FROM Empleados WHERE NIF LIKE @nif and admin like '1'");
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

    }
}
