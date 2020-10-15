using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random rand = new Random();

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = rand.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
            
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre y apellido: {this.nombre} {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            if(this.notaFinal != -1)
            {
                sb.AppendLine($"Nota 1: {this.nota1}\nNota 2: {this.nota2}\n");
                sb.AppendLine($"Nota final: {this.notaFinal}");
            } else
            {
                sb.AppendLine("Nota final: Desaprobado");
            }

            return sb.ToString();
        }

    }
}
