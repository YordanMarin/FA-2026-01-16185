using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese lado 1: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (lado1==lado2 && lado2 == lado3)
                Console.WriteLine("EQUILATERO");
            else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                Console.WriteLine("ISOSCELES");
            else
                Console.WriteLine("ESCALENO");
        }
    }
}
