using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine("\n----- IMPRESO CON + ----");
            Console.WriteLine(nombre+", Bienvenido al curso de Fundamentos de Algoritmos de la carrera "+carrera);

            Console.WriteLine("\n----- IMPRESO CON $ ----");
            Console.WriteLine($"{nombre}, Bienvenido al curso de Fundamentos de Algoritmos de la carrera {carrera}");
            Console.ReadKey();
        }
    }
}
