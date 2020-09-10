using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
operación que desea realizar (pulsando el caracter +, -, * ó /).
El usuario decidirá cuándo finalizar el programa.
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática. El método devolverá el resultado de la operación.
b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO.
*/
namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°15";

            bool continuar = true;

            do
            {
                //Ingreso datos
                Console.WriteLine("Ingresar 1er numero");
                int.TryParse(Console.ReadLine(), out int valor1);
                Console.WriteLine("Ingresar 2donumero");
                int.TryParse(Console.ReadLine(), out int valor2);
                Console.WriteLine("Ingresar operacion");
                char operador = Console.ReadKey(true).KeyChar;
                Console.WriteLine();
                // Muestro resultado
                Console.WriteLine($"{valor1} {operador} {valor2} = {Calculadora.Calcular(valor1, valor2, operador)}");
                // Continuar?
                Console.WriteLine("Desea realizar otra operacion? S/N");
                if (char.ToLower(Console.ReadKey(true).KeyChar) != 's')
                {
                    continuar = false;
                }
       


            } while (continuar);

            Console.ReadKey();
        }
    }
}
