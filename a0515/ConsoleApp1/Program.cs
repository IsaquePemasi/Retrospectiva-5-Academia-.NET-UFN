namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");

            Veiculo v = new Veiculo();
            v._potencia = 500;
            v._modelo = "Gol";
            v.Ligar();


            VeiculoEletrico ve = new VeiculoEletrico();
            ve._potencia = 100;
            ve._modelo = "Tesla";
            ve._autonomia = 10;
            ve.Ligar();
            ve.Carregar();

            Motocicleta m = new Motocicleta();
            m.Ligar();

            Veiculo vei;
            Console.WriteLine("Digite V para criar um Veiculo base\nDigite E para criar um Veiculo eletrico");
            Console.WriteLine("Digite M para criar uma Motocicleta");
            char op;
            op = char.Parse(Console.ReadLine());

            if(op == 'V')
                vei = new Veiculo();
            else if (op=='E')
                vei = new VeiculoEletrico();
            else if (op  == 'M')
                vei = new Motocicleta();
            else
                vei = new Veiculo();

            vei.Ligar(); */


            //Animal a = new Animal("Ricardo", 35);

            Cavalo c = new Cavalo("Ricardo", 35, "Vira lata");
            c.emitirSom();

            Cachorro cc = new Cachorro("Caramelo", 10);
            cc.p = new Pessoa("Ricardo");
            cc.p.end = new Endereco("Andradas", "97060-000", 1614);

            Console.WriteLine("O cachorro: " + cc.Nome + " é do " + cc.p.Nome);
            Console.WriteLine("E mora na rua " + cc.p.end.Rua + " numero " + cc.p.end.Numero);

            Pessoa pessoa = new Pessoa("Ayong");
            pessoa.caes = new List<Cachorro>();
            pessoa.caes.Add(cc);
            pessoa.caes.Add(new("Guaipeca", 5));
            pessoa.caes.Add(new("Snow", 6));
            pessoa.caes.Add(new("Hugo", 15));

            for (int i = 0; i < pessoa.caes.Count; i++)
            {
                Console.WriteLine("Cão " + i + ": " + pessoa.caes[i].Nome);
            }

            foreach (Cachorro cao in pessoa.caes)
            {
                Console.WriteLine("Cão no foreach: " + cao.Nome);
            }

            Console.WriteLine("Bem vindo!");
            IMotor motor;

            MotorEletrico me = new MotorEletrico();

            Console.WriteLine("Digite 1 para ligar o motor elétrico e 2 para ligar o motor a combustão: ");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                motor = new MotorEletrico();
                motor.Ligar();

                motor.Deligar();
            }
            else if (op == 2)
            {
                motor = new MotorCombustao();
                motor.Ligar();
                motor.Deligar();
            }
        }
    }
}

//Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de 
//Pessoa. A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade 
//adicional Disciplina. Criar um método Apresentar na classe Pessoa que imprime o nome e a idade da pessoa. Em seguida, criar um 
//método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe Professor
//que imprime o nome, a idade e a disciplina do professor.

//Criar uma classe Veiculo que contém as propriedades Marca e Modelo. Criar duas classes derivadas, Carro e Moto, que herdam de 
//Veiculo. A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade 
//adicional Cilindrada. Criar um método Dirigir na classe Veiculo que imprime "Dirigindo o <marca> <modelo>". Em seguida, criar um 
//método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na
//classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas".
