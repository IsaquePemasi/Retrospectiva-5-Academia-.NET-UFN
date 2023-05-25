namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();

            linhasArquivo = 

            // Leitura do arquivo .txt
            foreach (string linha in linhasArquivo)
            {
                if (linha.StartsWith("Z-"))
                {
                    // Dados de Pessoa
                    string[] dadosPessoa = linha.Split('-');
                    string nome = dadosPessoa[1];
                    string telefone = dadosPessoa[2];
                    string cidade = dadosPessoa[3];
                    string rg = dadosPessoa[4];
                    string cpf = dadosPessoa[5];

                    Pessoa pessoa = new Pessoa(nome, telefone, cidade, rg, cpf);
                    pessoas.Add(pessoa);
                }
                else if (linha.StartsWith("Y-"))
                {
                    // Dados de Aluno
                    string[] dadosAluno = linha.Split('-');
                    string matricula = dadosAluno[1];
                    string codigoCurso = dadosAluno[2];
                    string nomeCurso = dadosAluno[3];

                    Aluno aluno = new Aluno(matricula, codigoCurso, nomeCurso);
                    alunos.Add(aluno);
                }
                // Quantidade de objetos Pessoa e Aluno criados
                Console.WriteLine("Quantidade de objetos Pessoa: " + pessoas.Count);
                Console.WriteLine("Quantidade de objetos Aluno: " + alunos.Count);

                // Mostrar os cursos de cada Aluno
                foreach (Aluno aluno in alunos)
                {
                    Console.WriteLine("Curso do Aluno - Matrícula: " + aluno.Matricula);
                    Console.WriteLine("Código do curso: " + aluno.CodigoCurso);
                    Console.WriteLine("Nome do curso: " + aluno.NomeCurso);
                    Console.WriteLine();
                }
            }
        }
    }
}