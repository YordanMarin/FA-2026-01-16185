using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            int num, par=0, impar=0;
            do
            {
                Console.Write("Ingrese número positivo (negativo para salir): ");
                num = int.Parse(Console.ReadLine());

                if(num != 0)
                {
                    if (num % 2 == 0) par++;
                    if (num % 2 != 0) impar++;
                }
            } while (num>=0);

            Console.WriteLine("\nCantidad pares: "+par);
            Console.WriteLine("cantidad impares: " + impar);
        }
    }
}
