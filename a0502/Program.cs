using System;
using System.Text.RegularExpressions;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----Pessoa

            //Pessoa p1 = new Pessoa();
            //Console.WriteLine("Digite um nome: ");
            //p1.nome = Console.ReadLine();
            //Console.WriteLine("Digite a idade da " + p1.nome);
            //p1.idade = int.Parse(Console.ReadLine());

            ////Console.WriteLine("A pessoa instanciada é: " + p1.nome);
            ////Console.WriteLine("A idade instanciada da " + p1.nome + " é: " + p1.idade); 

            //p1.exibeDados();
            //Pessoa p2 = new Pessoa("Julia", 18);
            //p2.exibeDados();

            //-----Carro

            //Carro carro = new Carro();
            //Carro carro2 = new Carro();

            //Console.WriteLine("Digite a marca do carro: ");
            //carro.marca = Console.ReadLine();
            //Console.WriteLine("Digite o modelo do carro: " + carro.marca) ;
            //carro.modelo = Console.ReadLine();
            //Console.WriteLine("Digite o ano de fabricação, do modelo: " + carro.modelo);
            //carro.anoFabricacao = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a marca do carro: ");
            //carro2.marca = Console.ReadLine();
            //Console.WriteLine("Digite o modelo do carro: " + carro2.marca);
            //carro2.modelo = Console.ReadLine();
            //Console.WriteLine("Digite o ano de fabricação, do modelo: " + carro2.modelo);
            //carro2.anoFabricacao = int.Parse(Console.ReadLine());

            //carro.exibeDados();
            //carro2.exibeDados();

            //-----Computador

            // Computador comp = new Computador();
            // Console.WriteLine("Marca: ");
            // comp.marca = Console.ReadLine();
            // Console.WriteLine("Modelo: ");
            // comp.modelo = Console.ReadLine();
            // Console.WriteLine("tipo: " );
            // comp.tipo = Console.ReadLine(); 
            // Console.WriteLine("preço");
            // comp.preco = int.Parse(Console.ReadLine());

            // Computador comp2 = new Computador("Lenovo", "Ideapad" , "Novo", 1200);

            // comp.exibeDados();
            // comp2.exibeDados();

            //-----People

            // Console.WriteLine("1 - Com idade");
            // Console.WriteLine("2 - Com nome e idade  ");
            // int n = int.Parse(Console.ReadLine());
            // if (n == 1)
            // {
            //     Console.WriteLine("Idade: ");
            //     int idade = int.Parse(Console.ReadLine());
            //     People pessoa = new People(idade);
            //     pessoa.conteudo();
            // }
            // else if (n == 2)
            // {
            //     Console.WriteLine("Idade: ");
            //     int idade = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Nome: ");
            //     string nome = Console.ReadLine();
            //     People pessoa = new People(idade, nome);
            //     pessoa.conteudo();
            // }
            // else
            // {
            //     Console.WriteLine("Erro!");

            //-----Aluno

            // Aluno aluno1 = new Aluno("Isaque", 2023);
            // Aluno aluno2 = new Aluno(21);
            // Aluno aluno3 = new Aluno("Julia", 21, 2022);

            //-----Conta corrente

            ContaCorrente conta = new ContaCorrente();
            conta.definirSaldoInicial(1200);
            conta.depositar(1200);
            conta.sacar(1200);
            Console.WriteLine(conta.saldo);
        }
    }
}


//•Crie uma classe chamada Computador que possua 4 atributos: marca, modelo, tipo (notebook, netbook, tablet, etc) e preço.
//Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução.
//Já, os valores do segundo objeto, deverão ser definidos no código-fonte da classe que o criou. Exiba na tela os resultados.