using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesNIF
{
    public class Utilidad
    {

        private static char CalcularLetra(int valor)
        {
            const string tabla = "TRWAGMYFPDXBNJZSQVHLCKET";
            int indice;

            indice = (int)valor % 23;
            return tabla[indice];
        }

        public static string CalcularLetraNIF(string valorDNI)
        {
            valorDNI = valorDNI.ToUpper();
            char letra = CalcularLetra(Convert.ToInt32(valorDNI));
            return valorDNI + letra;
        }

        public static bool ValidarLetraNIF(string valorNIF)
        {
            valorNIF = valorNIF.ToUpper();

            char letra1 = valorNIF[valorNIF.Length - 1];
            string dni = valorNIF.Substring(0, valorNIF.Length - 1);

            char letra2 = CalcularLetra(Convert.ToInt32(dni));

            Console.WriteLine("Letra introducida: {0,-10}Letra válida: {1}", letra1, letra2);

            if (letra1 == letra2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
