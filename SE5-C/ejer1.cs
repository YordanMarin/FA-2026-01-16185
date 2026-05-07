using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Puede votar");
                if(edad >= 25)
                {
                    Console.WriteLine("Pueder ser politico");
                }
            }
            else Console.WriteLine("No puede votar ni ser politico");
        }
    }
}
