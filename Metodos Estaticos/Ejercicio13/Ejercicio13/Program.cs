using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
/*
 * Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
 * string DecimalBinario(int). Convierte un número de entero a binario.
 * int BinarioDecimal(string). Convierte un número binario a entero.
 * NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
 */
namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°13";

            Console.Write("Ingresar numero decimal: ");
            int.TryParse(Console.ReadLine(), out int bin);
            Console.WriteLine($"Binario: {Conversor.DecimalBinario(bin)}");

            Console.Write("Ingresar numero binario: ");
            Console.WriteLine(Conversor.BinarioDecimal(Console.ReadLine()));

            Console.ReadKey();
        }
    }
}
