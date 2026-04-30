using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SISTEMA DE CALCULO DE ÁREAS ---\n");

            Console.WriteLine("Menú de opciones: ");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Circulo\n");

            Console.Write("Ingrese una opción: ");
            int opc = int.Parse(Console.ReadLine());

            double area;

            switch (opc)
            {
                case 1:
                    Console.Write("\nIngrese lado: ");
                    int lc = int.Parse(Console.ReadLine());
                    area = lc * lc;
                    Console.WriteLine($"\nÁrea del cuadrado: {area}");
                    break;
                case 2:
                    Console.Write("\nIngrese base: ");
                    int br = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese altura: ");
                    int ar = int.Parse(Console.ReadLine());
                    area = br * ar;
                    Console.WriteLine($"\nÁrea del rectángulo: {area}");
                    break;
                case 3:
                    Console.Write("\nIngrese base: ");
                    int bt = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese altura: ");
                    int at = int.Parse(Console.ReadLine());
                    area = bt * at / 2;
                    Console.WriteLine($"\nÁrea del triángulo: {area}");

                    break;
                case 4:
                    Console.Write("\nIngrese radio: ");
                    int rc = int.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(rc, 2);
                    Console.WriteLine($"\nÁrea del circulo: {area}");
                    break;
                default: Console.Write("\nOpción incorrecta!"); break;
            }
        }
    }
}
