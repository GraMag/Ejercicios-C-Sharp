using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            vertice2 = new Punto(vertice3.GetX, vertice1.GetY);
            vertice4 = new Punto(vertice1.GetX, vertice3.GetY);
        }

        public float GetArea
        {
            get
            {
                if (area == 0)
                {
                    float baseRec = Math.Abs(vertice1.GetX - vertice2.GetX);
                    float alturaRec = Math.Abs(vertice1.GetY - vertice4.GetY);
                    area = baseRec * alturaRec;
                    return area;
                }
                return area;
            }
        }
 
        public float GetPerimetro
        {
            get
            {
                if (perimetro == 0)
                {
                    float baseRec = Math.Abs(vertice1.GetX - vertice2.GetX);
                    float alturaRec = Math.Abs(vertice1.GetY - vertice4.GetY);
                    perimetro = (baseRec + alturaRec) * 2;
                    return perimetro;
                }
                return perimetro;
            }
        }

        public static string MostrarDatos(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Vertice 1 ({rectangulo.vertice1.GetX}, {rectangulo.vertice1.GetY})");
            sb.AppendLine($"Vertice 2 ({rectangulo.vertice2.GetX}, {rectangulo.vertice2.GetY})");
            sb.AppendLine($"Vertice 3 ({rectangulo.vertice3.GetX}, {rectangulo.vertice3.GetY})");
            sb.AppendLine($"Vertice 4 ({rectangulo.vertice4.GetX}, {rectangulo.vertice4.GetY})");

            return sb.ToString();
        }
    }
}
