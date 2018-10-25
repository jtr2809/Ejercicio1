using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del arreglo:");
            int largo = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[largo];
            int[] arrayResultado = new int[largo];
            int num = 1;
            for (int i = 0; i < largo; i++)
            {
                array[i] = num;
                num++;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Ingrese número de rotaciones:");
            int rotar = Convert.ToInt32(Console.ReadLine());

            for (int u = 0; u < largo; u++)
            {
                int index = ((u + rotar) % largo);

                arrayResultado[u] = array[index];

                Console.Write(arrayResultado[u] + " ");
            }
            Console.ReadKey();
        }
    }
}
