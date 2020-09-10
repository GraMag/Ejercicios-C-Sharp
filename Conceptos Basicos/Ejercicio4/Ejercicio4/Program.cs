using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
 * (excluido el mismo) que son divisores del número.
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
 * Escribir una aplicación que encuentre los 4 primeros números perfectos.
 * Nota: Utilizar estructuras repetitivas y selectivas.
 */
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 4";
            
            int perfect = 0; // Cuenta la cantidad de numeros perfectos
            int numero = 1; // Aumenta en cada vuelta para ver si es perfecto o no
            
            // Repito el ciclo hasta encontrar los 4 numeros
            do 
            {
                int sumarNumeros = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0) // Si es multiplo entra
                    {
                        sumarNumeros += i; // Se van sumando los numeros 

                        // Si al llegar a la mitad del numero la suma de sus multiplos es igual al numero. ES UN NUMERO PERFECTO! :D
                        // Lo imprimo y salgo del bucle
                        if (i == (numero / 2) && sumarNumeros == numero) 
                        {
                            perfect++;
                            Console.WriteLine(numero);
                            break;
                        }
                    }
                    if(i > numero / 2) // Si llegue a la mitad del bucle no es un numero perfecto salgo 
                    {
                        break;
                    }
                }
                numero++;    
            } while (perfect < 4);

            Console.ReadKey();
        }
    }
}
