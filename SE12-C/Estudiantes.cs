using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE12_C
{
    public class Estudiantes
    {
        byte[] edad = new byte[0];
        int c = 0;

        public void insertar()
        {
            byte ed = 0;
            Console.Write("\nIngrese la edad: ");

            while (!byte.TryParse(Console.ReadLine(), out ed) || ed < 14 || ed > 120)
            {
                Console.Write("Error. Intente nuevamente: ");
            }

            Array.Resize(ref edad, edad.Length+1);
            edad[c] = ed;
            c++;
            Console.WriteLine("Edad registrado correctamente.");
        }

        public void mostrar()
        {
            Console.WriteLine("\n#\tEdad");
            for(int i = 0; i < edad.Length; i++)
            {
                Console.Write($"{i + 1}\t{edad[i]}\n");
            }
        }
        public int menu()
        {
            Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE EDADES\n");

            Console.WriteLine("*********** MENÚ DE OPCIONES *********");
            Console.WriteLine("* 1. Insertar                        *");
            Console.WriteLine("* 2. Mostrar                         *");
            Console.WriteLine("* 3. Eliminar                        *");
            Console.WriteLine("* 4. Ordenar                         *");
            Console.WriteLine("* 5. Salir                           *");
            Console.WriteLine("**************************************");

            int opc;

            do
            {
                Console.Write("\nIngrese una opción: ");
                opc = int.Parse(Console.ReadLine());
            } while (opc<=0 || opc >5);
            return opc;
        }
    }
}
