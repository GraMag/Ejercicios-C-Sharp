using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un numero de entero a binario
        /// </summary>
        /// <param name="n">Numero entero</param>
        /// <returns>Numero binario</returns>
        public static string DecimalBinario (int decimalNumber)
        {
            string binaryNumber = "";
            do
            {
                if (decimalNumber % 2 == 0)
                {
                    binaryNumber = "0" + binaryNumber;
                }
                else
                {
                    binaryNumber = "1" + binaryNumber;
                }
                decimalNumber = decimalNumber / 2;
            } while (decimalNumber > 0);
            return binaryNumber;
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binaryNumber">Numero binario</param>
        /// <returns>Numero decimal</returns>
        public static int BinarioDecimal (string binaryNumber)
        {
            int decimalNumber = 0;
            
            for (int i = binaryNumber.Length-1; i >= 0; i--)
            {
                if(binaryNumber[i] == '1')
                {
                    decimalNumber += (int)Math.Pow(2, binaryNumber.Length-1-i);
                }
            }

            return decimalNumber;
        }
    }
}
