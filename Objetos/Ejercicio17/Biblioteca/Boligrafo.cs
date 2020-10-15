using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        private const short cantidadTintaMaxima = 100;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tinta"></param>
        /// <param name="color"></param>
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        /// <summary>
        /// Getter de Tinta
        /// </summary>
        /// <returns></returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Getter de Color
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        private void SetTinta(short tinta)
        {
            if(this.tinta <= cantidadTintaMaxima && this.tinta - tinta >= 0)
            {
                this.tinta -= tinta;
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {   
            dibujo = "";
            if(this.tinta-gasto >= 0 && this.tinta-gasto <= cantidadTintaMaxima)
            {
                dibujo = "";
                for (int i = 0; i < gasto; i++)
                {
                    dibujo = "*" + dibujo;
                    
                }
                this.SetTinta(gasto);
                return true;
            }
            return false;
        }
    }
}
