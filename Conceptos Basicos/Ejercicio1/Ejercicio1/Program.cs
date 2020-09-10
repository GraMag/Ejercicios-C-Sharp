using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ingresar 5 números por consola, guardándolos en una variable escalar. 
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
 */

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 1";
            
            int num;
            int max = int.MinValue;
            int min = int.MaxValue;
            int total = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresar numero");
                int.TryParse(Console.ReadLine(), out num);
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                total += num;
            }
            Console.WriteLine("Minimo: {0}\nMaximo: {1}\nEl promedio es {2}", min, max, (float)total / 5);

            Console.ReadKey();
        }
    }
}
