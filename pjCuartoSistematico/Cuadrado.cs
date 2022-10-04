using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pjCuartoSistematico
{
    internal class Cuadrado : FiguraBidimensional
    {
        public Cuadrado(int b, int h, int l, int r) : base(b, h, l, r)
        {
           

        }

        public double l { get; internal set; }

        public int AreaCuadrado
        {
            get
            {
                return AreaCuadrado;
            }
            set
            {
                AreaCuadrado = (int)Math.Pow(l, 2); ;
            }
        }

        public int VolumenCuadrado
        {
            get
            {
                return VolumenCuadrado; 
            }
            set
            {
                VolumenCuadrado = (int)(l * 4);
            }
        }

        
    }
}
