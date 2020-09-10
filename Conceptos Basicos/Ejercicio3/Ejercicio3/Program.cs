using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
 * por consola.
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 3";

            int num;
            
            // Pido los datos
            Console.WriteLine("Ingresar limite");
            int.TryParse(Console.ReadLine(), out num);

            // Valido que sea un numero positivo
            if(num < 1)
            {
                Console.WriteLine("ERROR: El numero debe ser positivo");
                int.TryParse(Console.ReadLine(), out num);
            }

            // Busco los numeros primos
            for(int i = 1; i <= num; i++)
            {
                int esPrimo = 0;
                for (int j = 1; j <= num; j++) 
                {

                    if (i % j == 0) // Si el resto es 0 sumo 1; 
                    {
                        esPrimo++;
                        if (esPrimo > 2) // Si el numero suma mas de 2 el bucle se interrumpe
                        {
                            break;
                        }
                    }
                }
                if(esPrimo == 2) // Si solo 2 numeros dieron resto 2, es un numero primo (1 y si mismo) entonces lo imprimo
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(); // Tocar una tecla para cerrar la consola
        }
    }
}
