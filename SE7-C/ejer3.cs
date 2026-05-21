using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_C
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            string continuar;
            int num;
            do
            {
                Console.Clear();
                Console.Write("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if (num <= 0) Console.WriteLine("El número debe de ser mayor a 0!\n");
                else
                {
                    int suma = 0;
                    int i = 1;
                    do
                    {
                        suma += i;
                        i++;
                    } while (i<=num);
                    Console.WriteLine($"\nLa suma de los números de 1 hasta {num} es {suma}");
                }

                Console.Write("\n¿Desea continar? (presione si): ");
                continuar = Console.ReadLine();
            } while (continuar == "si");
        }
    }
}
