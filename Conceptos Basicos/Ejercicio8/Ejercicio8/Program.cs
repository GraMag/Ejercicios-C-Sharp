using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
 * trabajadas en el mes de N empleados de una fábrica.

 * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
 * valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
 * multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
 * descuentos.
 * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
 * bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
 * Nota: Utilizar estructuras repetitivas y selectivas.
 */
namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°8";

            double valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            bool continuar = true;
            do
            {
                Console.WriteLine("Ingresar valor hora");
                double.TryParse(Console.ReadLine(), out valorHora);
                Console.WriteLine("Ingresar nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresar antiguedad");
                int.TryParse(Console.ReadLine(), out antiguedad);
                Console.WriteLine("Ingresar horas trabajadas");
                int.TryParse(Console.ReadLine(), out horasTrabajadas);

                double total = valorHora * horasTrabajadas + antiguedad * 150;
                double descuento = total * 0.13;

                Console.WriteLine($"Nombre: {nombre}\n" +
                    $"Antiguedad: {antiguedad}\n" +
                    $"Valor por hora: ${valorHora}\n" +
                    $"Total bruto: ${total}\n" +
                    $"Total descuentos: ${descuento}\n" +
                    $"Total neto: ${total - descuento}");

                Console.WriteLine("Ingresar otro empleado S / N");
                if (Console.ReadLine() == "N")
                {
                    continuar = false;
                }
            } while (continuar);
            Console.ReadKey();
        }
    }
}
