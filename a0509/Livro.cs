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

        public void Exibe()
        {
            Console.WriteLine(Titulo);
            Console.WriteLine(Autor.Nome);
        }
    }
}
//13 - Crie uma classe autor. Em seguida, crie uma classe "Livro" com os atributos "titulo" e "autor". O atributo autor, deve ser 
//uma instancia de uma classe Autor. Crie um método para exibir as informações do livro.