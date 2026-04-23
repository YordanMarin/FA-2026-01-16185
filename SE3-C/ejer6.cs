using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer6
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese segundos: ");
            int s = int.Parse(Console.ReadLine());

            int h = s / 3600;
            int m = (s % 3600) / 60;
            int sr = s % 60;

            Console.WriteLine($"\n{h} : {m} : {sr}");
        }
    }
}
