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


        public bool IniciarSesion(string clau)
        {
            return clave == clau;
        }
    }
}
