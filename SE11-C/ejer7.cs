using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE11_C
{
    internal class ejer7
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad N de números: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            Random rnd = new Random();
            Console.WriteLine();
            Console.Write("Lista aleatoria: ");
            for(int i=0; i<num.Length; i++)
            {
                num[i] = rnd.Next(0,51);
                Console.Write(num[i]+" ");
            }

            Console.Write("\n\nIngrese un número a buscar: ");
            int buscar = int.Parse(Console.ReadLine());
            bool encontrar = false;

            for(int i = 0; i < cant; i++)
            {
                if(buscar == num[i])
                {
                    Console.WriteLine("\nNúmero existe en posición "+i);
                    encontrar = true;
                    break;
                }
            }
            if (!encontrar) Console.WriteLine("\nNúmero no existe");
        }
    }
}
