using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- SISTEMA DE CONVESIÓN DE MONEDA ----\n");

            Console.Write("Ingrese el monto en soles: ");
            double soles = double.Parse(Console.ReadLine());

            Console.WriteLine("\n***** MENÚ DE OPCIONES ****");
            Console.WriteLine("* 1. Dolares              *");
            Console.WriteLine("* 2. Euros                *");
            Console.WriteLine("***************************\n");

            Console.Write("Ingrese una opción: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 0:
                    double dolares;
                    dolares = soles / 3.75;

                    Console.WriteLine("\nDolares: "+Math.Round(dolares));

                    break;
                case 1:
                    double euro;
                    euro = soles / 3.75;

                    Console.WriteLine("\nDolares: " + Math.Round(euro,1));
                    break;
                default: Console.Write("\nOpción incorrecta!"); break;
            }

        }
    }
}
