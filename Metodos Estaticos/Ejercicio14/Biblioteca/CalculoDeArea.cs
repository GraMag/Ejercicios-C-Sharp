using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CalculoDeArea
    {
        /// <summary>
        /// Calcula el area de un cuadrado
        /// </summary>
        /// <param name="n">Lado</param>
        /// <returns>Area del cuadrado</returns>
        public static double CalcularCuadrado(double n)
        {
            return Math.Pow(n, 2);
        }

        /// <summary>
        /// Calcula el area de un triangulo recto
        /// </summary>
        /// <param name="b">Base</param>
        /// <param name="a">Altura</param>
        /// <returns>Area de un triangulo recto</returns>
        public static double CalcularTriangulo(double b, double a)
        {
            return (b * a) / 2;
        }

        /// <summary>
        /// Calcula el area de un circulo
        /// </summary>
        /// <param name="r">Radio</param>
        /// <returns>Area del circulo</returns>
        public static double CalcularCirculo(double r)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2), 2); 
        }
    }
}
