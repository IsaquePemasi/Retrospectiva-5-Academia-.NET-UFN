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
        private string nome;
        private double nota1;
        private double nota2;
        private double nota3;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        public double CalcularMedia()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public string VerificarAprovacao()
        {
            double media = CalcularMedia();
            if (media >= 6)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
//11 - Crie uma classe "Aluno" com os atributos "nome", "nota1", "nota2" e "nota3". Os atributos devem ser privados e
//acessados através de propriedades. Em seguida, crie um método para calcular a média e verificar se o aluno está aprovado 
//ou reprovado (se a nota for maior ou igual a 6, está aprovado, senão está reprovado).