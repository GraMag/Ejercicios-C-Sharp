using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribir un programa que determine si un año es bisiesto.
 * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
 * también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
 * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/
namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 6";

            int anioMin, anioMax;

            //Ingreso datos
            Console.WriteLine("Ingrese año inicial (YYYY)");
            int.TryParse(Console.ReadLine(), out anioMin);

            Console.WriteLine("Ingrese año final (YYYY)");
            int.TryParse(Console.ReadLine(), out anioMax);

            //Valido que el segundo año sea mayor que el primer año
            while(anioMax < anioMin)
            {
                Console.WriteLine("ERROR. El año ingresado es menor que el año inicial. \nIngrese año final (YYYY)");
                int.TryParse(Console.ReadLine(), out anioMax);
            }

            Console.WriteLine();

            //Recorro el rango de años, si es bisiesto lo muestro.
            for(int i = anioMin; i <= anioMax; i++)
            {
                if(i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
