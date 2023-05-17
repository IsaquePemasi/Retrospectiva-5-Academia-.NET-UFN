using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IRetangulo : IFormaGeometrica
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double CalcularArea()
        {
            return Altura * Largura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Altura + Largura);
        }
    }
}
