using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE11_C
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("LISTA DE PARES: ");
            for (int i = 0; i < 10; i++)
            {
                if (num[i] % 2 == 0)
                    Console.Write(num[i] + " ");
            }
        }
    }
}
