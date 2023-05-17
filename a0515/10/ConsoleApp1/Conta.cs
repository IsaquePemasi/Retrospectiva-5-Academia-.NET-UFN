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
        public int Numero { get; set; }
        public int Saldo { get; set; }
    }
}

//4 - Crie uma classe Conta com as propriedades Numero e Saldo. Em seguida, crie as classes ContaCorrente e ContaPoupanca que herdam de Conta e adicionam uma propriedade TaxaDeJuros e LimiteDeCredito, respectivamente.