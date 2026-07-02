using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_15
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de filas: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f, c];
            int[] suma = new int[c];
            Random rnd = new Random();

            Console.WriteLine("\nMATRIZ ORIGINAL");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(20, 31);
                    suma[j] += matriz[i, j];
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int i = 0;i < suma.Length; i++)
            {
                Console.Write(suma[i]+"\t");
            }
            Console.ReadKey();
        }
    }
}
