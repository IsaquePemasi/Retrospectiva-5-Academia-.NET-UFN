using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conta
    {
        public int numero;
        public int saldo;
        public int limite;

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public int Saldo
        {
            get
            {
                return saldo;
            }
            set {
                if (saldo < 0)
                {
                    Console.WriteLine("Saldo menor que zero");
                }
                saldo = value; 
            }
        }
        public int Limite
        {
            get
            {
                return limite;
            }
            set
            {
                if (limite < 0)
                {
                    Console.WriteLine("Limite negativo");
                }
                limite = value;
            }
        }
    }
}

//5 - Crie uma classe chamada Conta que tenha as propriedades Número, Saldo e Limite. Utilize o encapsulamento para 
//garantir que o saldo nunca seja menor que zero e que o limite seja positivo e que o Número da conta não possa
//ser alterado.