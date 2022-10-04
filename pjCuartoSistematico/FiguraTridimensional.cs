using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCuartoSistematico
{
    internal class FiguraTridimensional : Figura
    {
        private int radio;
        public FiguraTridimensional(int b, int h, int l, int r) : base(b, h, l)
        {
            radio = r;  
        }

    }
}
