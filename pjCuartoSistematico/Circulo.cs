using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCuartoSistematico
{
    internal class Circulo : FiguraBidimensional
    {
        public Circulo(int b, int h, int l, int r) : base(b, h, l, r)
        {

        }

        public int r { get; internal set; }

        public int AreaCirculo
        {
            get
            { 
                return AreaCirculo;
            }

            set
            { 
                AreaCirculo = (int)Math.Abs(Math.Pow(r, 2));
            }
            //Math.Abs contiene PI y .Pow es para el exponente
        }

        public int PerimetroCirculo
        {
            get
            { 
                return PerimetroCirculo;
            }

            set
            {
                PerimetroCirculo = (int)((int)2* Math.Abs(r));
            }
        }
    }
}
