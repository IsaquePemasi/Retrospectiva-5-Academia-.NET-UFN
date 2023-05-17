using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class ContaBancaria
    {
        public abstract string Titular { get; set; }
        public abstract int Saldo { get; set; }
        public abstract int TaxaDeJuros { get; set; }
    }
}
//7 - Classe Abstrata "ContaBancaria"
//Crie uma classe abstrata chamada "ContaBancaria" com três propriedades abstratas: "Titular", "Saldo" e "TaxaDeJuros". Em seguida, crie duas classes que herdam de "ContaBancaria": "ContaCorrente" e "ContaPoupanca". Implemente as propriedades "Titular", "Saldo" e "TaxaDeJuros" para cada uma dessas classes. Por fim, crie um objeto "ContaCorrente" e um objeto "ContaPoupanca", e imprima as suas propriedades na tela.
