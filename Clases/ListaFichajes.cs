
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    internal class ListaFichajes
    {
        private List<Fichaje> fichajesAbiertos;
        private List<Fichaje> todosLosFichajes;


        public List<Fichaje> FichajesAbiertos { get { return fichajesAbiertos; } }
        public List<Fichaje> TodosLosFichajes { get { return todosLosFichajes; } }

        public ListaFichajes() { }

        public List<Fichaje> FichajesCompleto()
        {
            string consulta = "select * from Fichaje";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Fichaje fit = new Fichaje(reader.GetString(0), reader.GetDateTime(0), reader.GetDateTime(0));
                    todosLosFichajes.Add(fit);
                }
            }
            reader.Close();
            return TodosLosFichajes;
        }

        
    }

    

}



