using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

/*
 * Crear la clase Alumno de acuerdo al siguiente diagrama:
 * (imagen)
 * a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
 * nombre, apellido y legajo a cada uno de ellos.
 * b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
 * c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
 * iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
 * el método de instancia Next de la clase Random.
 * d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
 * mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
 * desaprobado".
 */
namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Pedro", "Perez", 123);
            Alumno alumno2 = new Alumno("Pablo", "Marmol", 624);
            Alumno alumno3 = new Alumno("Vilma", "Picapiedras", 734);

            alumno1.Estudiar("gato", 7);
            alumno2.Estudiar(2, 1);
            alumno3.Estudiar(10, 2);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
