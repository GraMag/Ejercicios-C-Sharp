using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            if(char.ToLower(c) == 's')
            {
                return true;
            }
            return false;
        }
    }
}
