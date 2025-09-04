using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    class Retangulo
    {
        public int Altura;
        public int Largura;
        public Retangulo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }
        public Retangulo()
        {
        }
        public int Area()
        {
            return Altura * Largura;
        }
        public int Perimetro()
        {
            
            return 2 * Altura + 2 * Largura;
        }

    }
}
