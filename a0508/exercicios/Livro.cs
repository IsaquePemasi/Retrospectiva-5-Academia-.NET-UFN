using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Livro
    {
        public string titulo;
        public Autor autor;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                       throw new ArgumentNullException("Titulo nulo ou vazio");
                }
                titulo = value; 
            }
        }
        public Autor Autor
        {
            get { return autor; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("O autor do livro não pode estar vazio.");
                }
                autor = value;
            }
        }
    }
}
//7 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe). Utilize o encapsulamento 
//para garantir que o título e o autor não sejam vazios.