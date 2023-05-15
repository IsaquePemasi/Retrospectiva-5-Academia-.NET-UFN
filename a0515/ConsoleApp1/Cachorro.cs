using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cachorro : Animal
    {
        public Pessoa p;
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override void emitirSom()
        {
            throw new NotImplementedException();
        }
    }
}

