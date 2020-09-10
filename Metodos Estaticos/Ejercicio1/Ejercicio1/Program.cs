using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
/*
 * Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
anteriormente que esten dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.
*/
namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°11";
            int min = int.MaxValue;
            int max = int.MinValue;
            int total = 0;
            int numerosValidos = 0;

            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresar numero");
                int.TryParse(Console.ReadLine(), out int valor);

                //Si cumple con la validacion busco minimos, maximos. Sumo los numeros validos y la cantidad
                 if(Validaciones.Validate(valor, -100, 100))
                {
                    total += valor;
                    numerosValidos++;

                    if(valor > max)
                    {
                        max = valor;
                    }
                    if(valor < min)
                    {
                        min = valor;
                    }
                }
            }
            Console.WriteLine($"Minimo: {min}\nMaximo: {max}\nPromedio: {Math.Round((double)total / numerosValidos, 2)}");
            Console.ReadKey();

        }
    }
}
