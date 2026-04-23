using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            string num = Console.ReadLine();

            double deci = double.Parse(num);
            int entero = (int)Math.Round(deci);

            Console.WriteLine($"\nEntero %2: {entero%2}");
            Console.WriteLine($"decimal /3: {deci/3}");
        }
    }
}
