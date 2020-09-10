using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
/*
 * Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
 * un mensaje "¿Continuar? (S/N)".
 * En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
 * opciones.
 * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
 * cualquier otro valor.
*/
namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 12";
            bool continuar = true;
            int total = 0;

            do
            {
                Console.WriteLine("Ingresar un numero");
                int.TryParse(Console.ReadLine(), out int numero);
                total += numero;
                Console.WriteLine("Desea ingresar otro numero? S/N");
                continuar = ValidarRespuesta.ValidaS_N(Console.ReadLine()[0]); 
            } while (continuar);

            Console.WriteLine($"El total es {total}");
            Console.ReadKey();
        }
    }
}
