using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCuartoSistematico
{
    internal class Cubo : FiguraTridimensional
    {
        public Cubo(int b, int h, int l, int r) : base(b, h, l, r)
        {
        
        }

        public int l { get; internal set; }

        public int AreaCubo
        {
            get 
            { 
                return AreaCubo;
            }

            set
            {
                AreaCubo = (int)(6 * Math.Pow(l, 2));
            }
        }

        public int VolumenCubo
        {
            get { return VolumenCubo; }
            set { VolumenCubo = (int)(Math.Pow(l, 3)); }
        }
    }
}
