using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCuartoSistematico
{
    internal class Esfera : FiguraTridimensional
    {
        public Esfera(int b, int h, int l, int r) : base(b, h, l, r)
        {

        }

        public int r { get; internal set; }

        public int AreaEsfera
        {
            get
            {
                return AreaEsfera;
            }

            set
            {
                AreaEsfera = (int)((int)Math.Abs(4) * Math.Pow(r, 2));
            }
        }

        public int VolumenEsfera
        {
            get
            {
                return VolumenEsfera;
            }

            set
            {
                VolumenEsfera = (3 / 4) * (int)Math.Abs(Math.Pow(r, 2));
            }

        }
    }
}
