using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCuartoSistematico
{
    internal class FiguraBidimensional : Figura
    {
        private int radio;
        public FiguraBidimensional(int b, int h, int l, int r) : base(b, h, l)
        {
            this.radio = r;
        }
    }
}
