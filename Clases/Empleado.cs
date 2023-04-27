﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
        

        public string Nif { get { return nif; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }


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




        public virtual int AgregarEmpleado()
        {

            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Empleados (nif, nombre, apellidos, admin, clave) " +
                    "VALUES (@nif, @nombre, @apellidos, false,null);";
                cmd.Parameters.AddWithValue("@nif", this.nif);
                cmd.Parameters.AddWithValue("@nombre", this.nombre);
                cmd.Parameters.AddWithValue("@apellidos", this.apellidos);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }

        public static int EliminarEmpleado( string nif)
        {

            int retorno;

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "DELETE FROM empleados WHERE nif like @nif;";
                cmd.Parameters.AddWithValue("@nif",nif);
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
                informacion = $"NIF: {reader.GetString(0)}{Environment.NewLine}Nombre: {reader.GetString(1)}{Environment.NewLine}Apellidos: {reader.GetString(2)}{Environment.NewLine}Administrador: ";//{reader.GetBoolean(3)};
                if (reader.GetBoolean(3) == false) informacion += "NO eres administrador";
                else informacion += "SI eres administrador";
            } //asi?

            reader.Close();
            return informacion;
        }

        public static string InformacionPresencia()
        {
            string consulta = "SELECT e.nombre, e.apellidos, f.dia_hora_entrada FROM Empleados e INNER JOIN Fichaje f ON e.nif = f.nif_empl WHERE f.dia_hora_salida IS NULL;";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            string info = $"NOMBRE Y APELLIDOS".PadRight(20);
            info += $"ENTRADA{Environment.NewLine}".PadLeft(25);

            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    info += $"{Environment.NewLine}{reader.GetString(0)} {reader.GetString(1)}".PadRight(23);
                    info += $"{reader.GetDateTime(2).ToString()}".PadLeft(22);
                } 
            }
            reader.Close();
            return info;  
        }

        public static List<Empleado> ListaEmpleados()
        {
            List<Empleado> todosLosEmpl = new List<Empleado>();
            string consulta = "select * from Empleados where clave is null;";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Empleado emp = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    todosLosEmpl.Add(emp);
                }
            }
            reader.Close();
            return todosLosEmpl;
        }

    }
}
