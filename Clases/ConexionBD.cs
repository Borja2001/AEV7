﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AEV7
{
    internal class ConexionBD
    {
       

            private static MySqlConnection instancia = null;
            private static readonly object padlock = new object();
            private ConexionBD() { }

            public static MySqlConnection Conexion
            {
                get
                {
                    lock (padlock)
                    {
                        if (instancia == null)
                        {
                            instancia = new MySqlConnection();

                            string server = "server=127.0.0.1;";
                            string database = "database=aev7;";
                            string usuario = "uid=root;";
                            string password = "pwd=;";
                            instancia.ConnectionString = server + database + usuario + password;
                        }

                        return instancia;
                    }
                }
            }

            /// <summary>
            /// Método que abre la conexión con la base de datos
            /// </summary>
            public static void AbrirConexion()
            {
                if (instancia != null)
                    instancia.Open();
            }


            /// <summary>
            /// Método que cierra la conexión con la base de datos
            /// </summary>
            public static void CerrarConexion()
            {
                if (instancia != null)
                    instancia.Close();
            }

        }
    
}
