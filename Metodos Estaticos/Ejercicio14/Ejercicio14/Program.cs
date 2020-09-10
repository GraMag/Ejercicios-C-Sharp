using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/
namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°14";
            int valor;

            /// Cuadrado ///
            Console.WriteLine("Ingresar lado del cuadrado");
            int.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine($"El area del cuadrado es: {CalculoDeArea.CalcularCuadrado(valor)}");

            /// Triangulo ///
            Console.WriteLine("Ingresar base del triangulo");
            int.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine("Ingresar altura del triangulo");
            int.TryParse(Console.ReadLine(), out int valor2);
            Console.WriteLine($"El area del triangulo es: {CalculoDeArea.CalcularTriangulo(valor, valor2)}");
            
            /// Circulo ///
            Console.WriteLine("Ingresar radio del circulo");
            int.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine($"El area del circulo es: {CalculoDeArea.CalcularCirculo(valor)}");

            Console.ReadKey();
        }
    }
}
