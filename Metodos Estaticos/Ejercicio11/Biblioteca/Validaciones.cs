using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validaciones
    {
        public static bool Validate(int valor, int min, int max)
        {
            if(valor > min && valor < max)
            {
                return true;
            }
            return false;
        }
    }
}
