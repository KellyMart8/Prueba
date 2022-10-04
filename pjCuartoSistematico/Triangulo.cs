using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCuartoSistematico
{
    internal class Triangulo : FiguraBidimensional
    {
        public Triangulo(int b, int h, int l, int r) : base(b, h, l, r)
        {

        }

        public int b { get; internal set; }
        public int h { get; internal set; }
        public int l { get; internal set; }

        public double AreaTriangulo
        {
            get
            {
                return AreaTriangulo;
            }

            set
            {
                AreaTriangulo = (b * h) / 2;
            }

        }

        public double PerimetroTriangulo
        {
            get
            {
                return PerimetroTriangulo;
            }
            set
            {
                PerimetroTriangulo = l * 3;
            }
        }
    }
}
