using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Retangulo : Forma
    {
        public int Altura { get; set; }
        public int Base { get; set; }
        public virtual void CalcularArea()
        {
            Console.WriteLine(this.Altura * this.Base); 
        }
        public virtual void CalcularPerimetro()
        {
            Console.WriteLine(2 * (this.Altura + this.Base));
        }
    }
}
//5 - Crie uma classe Forma com os métodos CalcularArea e CalcularPerimetro. Em seguida, crie as classes Retangulo e Circulo que herdam de Forma e implementam os métodos CalcularArea e CalcularPerimetro de forma diferente.