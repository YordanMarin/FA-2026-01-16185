using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            int num;
            int Cpares=0, Cimpares=0, Cceros=0;

            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for(int i = 0; i < cant; i++)
            {
                Console.Write($"Ingrese número {i+1}: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    Cceros++;
                } else if(num%2 != 0)
                {
                    Cimpares++;
                }
                else
                {
                    Cpares++;
                }
            }
            Console.WriteLine("\n\nPares: "+Cpares);
            Console.WriteLine("Impares: "+Cimpares);
            Console.WriteLine("Ceros: "+Cceros);

        }
    }
}
