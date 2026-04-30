using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.Write("Edad: ");
            int ed = int.Parse(Console.ReadLine());

            if (ed < 18) Console.WriteLine("\nMenor de edad");
            else if(ed <= 64) Console.WriteLine("\nAdulto");
            else Console.WriteLine("\nAdulto mayor");

        }
    }
}
