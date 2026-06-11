using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE11_C
{
    internal class ejer6
    {
        static void Main(string[] args)
        {
            string[] nom = new string[5];
            int registrados = 0;

            for(int i = 0; registrados < nom.Length; i++)
            {
                Console.Write($"Ingrese nombre {registrados + 1}: ");
                string validar = Console.ReadLine();
                bool duplicado = false;

                for(int j = 0;j < registrados; j++)
                {
                    if (nom[j] == validar)
                    {
                        Console.WriteLine("No se permiten duplicados.");
                        duplicado = true;
                        break;
                    }
                }
                if (!duplicado)
                {
                    nom[registrados] = validar;
                    registrados++;
                }
            }
        }
    }
}
