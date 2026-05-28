using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace SE9_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar; 

            Triangulo t = new Triangulo();
            Rectangulo r = new Rectangulo();
            Trapecio tr = new Trapecio();
            Cuadrado c = new Cuadrado();

            do
            {
                Console.Clear();
                Console.WriteLine("BIEVENIDOS AL SISTEMA DE CALCULOS DE FIGURAS GEOMÉTRICAS\n");
                Console.WriteLine("1. Triángulo");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Cuadrado");
                Console.WriteLine("4. Trapecio");
                Console.WriteLine("5. Salir\n");

                Console.Write("Ingrese una opción: ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("BIEVENIDOS A LA FIGURA TRIÁNGULO\n");
                        Console.WriteLine("1. Área");
                        Console.WriteLine("2. Perímetro");
                        Console.Write("\nSeleccione una opción: ");
                        int opc2 = int.Parse(Console.ReadLine());

                        switch (opc2)
                        {
                            case 1:t.Area(); break;
                            case 2:t.Perimetro(); break;
                            default: Console.WriteLine("\nOpción no válida."); break;
                        }

                        break;
                    case 2:break;
                    case 3:break;
                    case 4:break;
                    case 5:Environment.Exit(0); break;
                    default: Console.WriteLine("\nOpción no válida."); break;
                }

                Console.Write("\n¿Desea continar? (presione [y]): ");
                continuar = Console.ReadLine();
            } while (continuar=="y");
            
        }
    }
}
