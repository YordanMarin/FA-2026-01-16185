using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Año: ");
            int an = int.Parse(Console.ReadLine());

            if((an % 4 == 0 && an%100 != 0) || an%400 ==0)
                Console.WriteLine("\nBisiesto");
            else Console.WriteLine("\nNo bisisesto");

            if (an%2==0) Console.WriteLine("Par");
            else Console.WriteLine("impar");
        }
    }
}
