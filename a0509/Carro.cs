using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Carro
    {
        public string modelo;
        public int ano;
        public double velocidade;

        public void Acelerar()
        {
            velocidade = velocidade + 10;
        }
        public void Frear()
        {
            if (velocidade <=0)
            {
                Console.WriteLine("Velocidade negativa");
                
            }
            else
            {
                velocidade = velocidade - 10;
            }

        }
    }
}
//12 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro
//(aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a 
//velocidade negativa).
