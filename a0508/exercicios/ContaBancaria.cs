using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContaBancaria
    {
        public int numeroConta;
        public string titular;
        public int saldo;
        public int limite;

        public void Depositar(int valor)
        {
            saldo = saldo + valor;
        }
        public void Sacar(int valor) {
            if (saldo>=valor)
            {
                saldo = saldo - valor;
            }
            else
            {
                throw new Exception("Saldo insuficente");
            }
        }

    }
}
//9 - Crie uma classe chamada ContaBancaria que tenha as propriedades NumeroConta, Titular, Saldo e Limite. Crie também
//um método chamado Depositar, que recebe um valor e adiciona ao saldo da conta, e um método Sacar, que recebe um 
//valor e verifica se o saldo é suficiente para a operação.