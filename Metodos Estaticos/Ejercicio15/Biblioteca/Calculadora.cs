using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza calculos matematicos
        /// </summary>
        /// <param name="n1">Numero X</param>
        /// <param name="n2">Numero Y</param>
        /// <param name="operacion">Simbolo matematico</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Calcular(int n1, int n2, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado =  n1 + n2;
                    break;
                case '-':
                    resultado = n1 - n2;
                    break;
                case '*':
                    resultado = n1 * n2;
                    break;
                case '/':
                    if (Validar(n2))
                    {
                        resultado = n1 / n2;
                    } else
                    {
                        resultado = 0;
                    }
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el divisor no sea 0
        /// </summary>
        /// <param name="n2">Divisor</param>
        /// <returns>[True] El numero no es 0 [False] El numero es 0</returns>
        private static bool Validar(int n2)
        {
            if(n2 != 0)
            {
                return true;
            }
            return false;
        }
    }
}
