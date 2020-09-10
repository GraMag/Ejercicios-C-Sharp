using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
 * calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
 * con DateTime.Now).
 * Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos. 
 */
namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese fecha de nacimiento(DD/MM/AAAA)");
            TimeSpan diasVividos = DateTime.Now.Subtract(DateTime.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Viviste {diasVividos.Days} dias");
            Console.ReadKey();
        }
    }
}
