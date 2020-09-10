using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, 
 * caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
*/

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 2";
            int num;

            Console.WriteLine("Ingrese un numero");
            int.TryParse(Console.ReadLine(), out num);

            while (num < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                int.TryParse(Console.ReadLine(), out num);
            }

            Console.WriteLine("{0} al cuadrado es {1} \n{0} al cubo es {2}", num, Math.Pow(num, 2), Math.Pow(num, 3));
            Console.ReadKey();
        }
    }
}
