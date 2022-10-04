using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCuartoSistematico
{
  
    internal class Tetraedro : FiguraTridimensional
    {
        public Tetraedro(int b, int h, int l, int r) : base(b, h, l, r)
        {

        }

        public int l { get; internal set; }
      

        public int AreaTetraedro
        {
            get
            {
                return AreaTetraedro;
            }

            set
            {
                AreaTetraedro = (int)(((double)Math.Pow(l, 2)) * Math.Sqrt(3));  //raiz de 3
            }
        }

        public int VolumenTetraedro
        {
            get
            {
                return VolumenTetraedro;
            }

            set
            {
                VolumenTetraedro = (int)(((double)Math.Pow(l, 2)) * Math.Sqrt(2) /12);
            }

        }
    }
}
