using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("|             BIENVENIDO AL JUEGO ADIVINADOR              |");
            Console.WriteLine("----------------------------------------------------------\n");

            Console.WriteLine("Intrucciones: ");
            Console.WriteLine("1. Ud. debe de adivinar el número que esta en el rango de 1-20.");
            Console.WriteLine("2. Ud. tiene tres intentos.");
            Console.WriteLine("3. Ud. vera un mensaje de apoyo por cada intento fallido\n");

            int intentos = 2;
            int num;
            Random rand = new Random();
            int aleatorio = rand.Next(1,21);

            do
            {
                Console.Write("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if(num == aleatorio)
                {
                    Console.WriteLine("Felicidades Ud, adivino el número\n");
                    break;
                }
                else if(num > aleatorio)
                {
                    Console.WriteLine("El número a adivinar es menor. Te quedan "+intentos+" intentos\n");
                    intentos--;
                }
                else
                {
                    Console.WriteLine("El número a adivinar es mayor. Te quedan "+intentos+" intentos\n");
                    intentos--;
                }
            } while (intentos>=0);

            if(intentos < 0)
            {
                Console.WriteLine("El número aleatorio era " + aleatorio);
            }
        }
    }
}
