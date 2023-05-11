using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aluno
    {
        public string nome;
        public int matricula;

        public string Nome
        {
            get { return nome; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nome vazio ou nulo");
                }
                nome = value;
            }
        }
        public int Matricula
        {
            get { return matricula; }
            set {
                if (matricula < 0 )
                {
                    throw new Exception("Numero da matrícula negativo ");
                }
                matricula = value; 
            }
        }
    }
}
//8 - Crie uma classe chamada Aluno que tenha as propriedades Nome e Matricula. Utilize o encapsulamento para garantir 
//que o nome não seja vazio (utilize função nativa) e que a matrícula seja positiva.
