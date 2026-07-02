using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_15
{
    internal class Productos
    {
        string[,] productos = new string[0, 3];
        int cantidad = 0;

        public void redimensionar(int nt)
        {
            string[,] nuevo = new string[nt, 3];

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                for (int j = 0; j < productos.GetLength(1); j++)
                {
                    nuevo[i, j] = productos[i, j];
                }
            }

            productos = nuevo;
        }

        public void registrar()
        {
            redimensionar(cantidad + 1);
            Console.Write("Ingrese el nombre del producto: ");
            productos[cantidad, 0] = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            productos[cantidad, 1] = Console.ReadLine();
            Console.Write("Ingrese el stock del producto: ");
            productos[cantidad, 2] = Console.ReadLine();

            cantidad++;
            Console.WriteLine("\nProducto registrado correctamente.");
        }
    }
}
