using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    internal class Fichaje
    {
        private string nif;
        private DateTime diaHoraEntrada;
        private DateTime horaSalida;

        public Fichaje(string nif)
        {
            diaHoraEntrada = DateTime.Today;
        }
    }
}
