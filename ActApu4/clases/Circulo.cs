using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActApu4.clases
{
   public class Circulo : FiguraGeometrica
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

}

