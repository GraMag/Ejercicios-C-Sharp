using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
    una pirámide como la siguiente:
        *
       ***
      *****
     *******
    *********
    Nota: Utilizar estructuras repetitivas y selectivas.
*/
namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°10";

            Console.WriteLine("Ingresar altura de la piramide");
            int.TryParse(Console.ReadLine(), out int heigth);

            for (int i = 1; i <= heigth; i++)
            {
                for (int j = heigth; j >= 0; j--)
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int k = heigth; k < heigth*2; k++)
                {
                    if (k < i + (heigth-1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
