using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
//6 - Crie uma classe Produto com as propriedades Codigo e Descricao. Em seguida, crie as classes Livro e CD que herdam de Produto e adicionam uma propriedade Autor e Artista, respectivamente.