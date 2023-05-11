using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class ContaCorrente
    {
        public double saldo;

        public void definirSaldoInicial(double valor)
        {
            saldo = saldo + valor;
        }

        public void depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool sacar(double valor)
        {
            saldo -= valor;
            if (saldo < 0)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
//3 - Crie uma classe ContaCorrente que obedeça à descrição abaixo: A classe possui o atributo saldo do tipo 
//double e os métodos definirSaldoInicial, depositar e sacar. O método definirSaldoInicial deve atribuir o
//valor passado por parâmetro ao atribuito saldo O método depositar, deve adicionar o valor passado por
//parâmetro ao atributo saldo O método sacar deve reduzir o valor passado por parâmetro do saldo já 
//existente
//Necessário verificar a condição de o valor do saldo ser insuficiente para o saque que se deseja
//fazer. O valor de retorno deve ser true (verdadeiro) quando for possível realizar o saque e false (falso)
//quando não for possível