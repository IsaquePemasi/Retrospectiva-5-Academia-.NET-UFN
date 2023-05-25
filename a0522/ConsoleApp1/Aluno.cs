using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aluno: Pessoa
    {
        public string Matricula { get; set; }
        public string CodigoCurso { get; set; }
        public string NomeCurso { get; set; }

        public Aluno(string matricula, string codigoCurso, string nomeCurso)
            : base("", "", "", "", "")
        {
            Matricula = matricula;
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }
    }
}
