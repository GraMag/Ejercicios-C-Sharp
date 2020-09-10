using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribir un programa que imprima por pantalla una pirámide como
 *   la siguiente:
 *  *
 *   ***
 *  *****
 *  *******
 *  *********
 *  El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
 *  ejemplo anterior la altura ingresada fue de 5.
 *  Nota: Utilizar estructuras repetitivas y selectivas.
*/
namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°9";

            Console.WriteLine("Ingresar altura de la piramide");
            int.TryParse(Console.ReadLine(), out int heigth);

            for (int i = 1; i <= heigth; i++)
            {
                for(int j = heigth; j >= 0; j--)
                {
                    if (i > j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
