using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo
{
    class triangulo
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;

        public double calculararea()
        {
            double a = (ladoA+ladoB + ladoC)/2;
            double p = Math.Sqrt(a * (a - ladoA) * (a - ladoB) * (a - ladoC));
            return p;
        }
    }
}
