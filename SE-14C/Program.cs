using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_14C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, ape;
            Console.Write("Ingreses sus nombres: ");
            nom = Console.ReadLine().Trim();
            Console.Write("Ingreses sus apellidos: ");
            ape = Console.ReadLine().Trim();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("# caracteres apellidos: "+ape.Length);
            Console.WriteLine("Nombres en mayus: "+nom.ToUpper());
            Console.WriteLine("Apellidos en minus: "+ape.ToLower());
            if (ape.CompareTo(nom) == 1)
                Console.WriteLine("Nombres y apellidos no son iguales");
            else 
                Console.WriteLine("Nombres y apellidos son iguales");
            if (!nom.Contains("an")==false)
                Console.WriteLine("Nombres si contiene la palabra an");
            else
                Console.WriteLine("Nombres no contiene la palabra an");

            Console.ForegroundColor = ConsoleColor.Blue;

            if (ape.IndexOf("a") == -1)
                Console.WriteLine("En apellidos no existe a");
            else
                Console.WriteLine("La posición es: " + ape.IndexOf("a"));
            
            if (ape.LastIndexOf("a") == -1)
                Console.WriteLine("En apellidos no existe a");
            else
                Console.WriteLine("La posición es: " + ape.LastIndexOf("a"));
            
            Console.WriteLine(nom.Insert(0, "UPN"));
            
            Console.WriteLine(ape.Insert(ape.Length,"SISTEMAS"));

            if (ape.Length > 5)
                Console.WriteLine(ape.Remove(5));
            else 
                Console.WriteLine("Apellidos no tiene al menos 5 caracteres");

            if (nom.Contains("a"))
                Console.WriteLine(nom.Replace("a","@"));
            else
                Console.WriteLine("En nombres no existe a");

            if (nom.Contains("a"))
            {
                string[] partes = nom.Split('a');
                for(int i = 0;  i < partes.Length; i++)
                {
                    Console.Write(partes[i]+" ");
                }
            }
               
            else
                Console.WriteLine("En nombres no existe a");

            Console.WriteLine();
            char[] vertical = nom.ToCharArray();
            for (int i = 0; i < vertical.Length; i++)
            {
                Console.WriteLine(vertical[i]);
            }

            char[] ordenado = nom.ToCharArray();
            Array.Sort(ordenado);
            for (int i = 0; i < ordenado.Length; i++)
            {
                Console.Write(ordenado[i]);
            }

            char[] reversa = nom.ToCharArray();
            Array.Reverse(reversa);
            for (int i = 0; i < reversa.Length; i++)
            {
                Console.Write(reversa[i]);
            }

        }
    }
}
