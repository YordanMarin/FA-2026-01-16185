using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Triangulo
    {
        public void Area()
        {
            int area;

            Console.Write("Ingrese la base: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura: ");
            int a = int.Parse(Console.ReadLine());

            area = (b * a) / 2;

            Console.WriteLine("\nEl ára de triángulo es "+area);
        }

        public void Perimetro()
        {
            Console.Write("Ingrese lado 1: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 3: ");
            int l3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl perímetro del triángulo es " + (l1 + l2 + l3));
        }
    }
}
