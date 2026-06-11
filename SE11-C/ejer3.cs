using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE11_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 50, 6, 3, 7, 20 };

            int maximo = num[0];
            int minimo = num[0];
            Console.WriteLine("LISTA DE NÚMEROS: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
                if (num[i] < minimo)
                    minimo = num[i];
                if (num[i] > maximo)
                    maximo = num[i];
            }
            Console.WriteLine("\n\nMínimo: " + minimo);
            Console.WriteLine("Máximo: " + maximo);
        }
    }
}
