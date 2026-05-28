using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo
    {
        public int Area()
        {
            Console.Write("Ingrese lado menor: ");
            int lmenor = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado mayor: ");
            int lmayor = int.Parse(Console.ReadLine());

            return lmenor * lmayor;
        }

        public int Perimetro()
        {
            Console.Write("Ingrese lado menor: ");
            int lmenor = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado mayor: ");
            int lmayor = int.Parse(Console.ReadLine());

            return lmenor + lmayor;
        }
    }
}
