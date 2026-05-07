using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            int pares = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i+" ");
                if (i%2==0)
                {
                    pares += i;
                    //pares = pares + i;
                }
            }
            Console.WriteLine("\n\nSuma de pares: "+pares);
        }
    }
}
