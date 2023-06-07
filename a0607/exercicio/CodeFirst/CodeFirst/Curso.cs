using System;
using System.Collections.Generic;

namespace CodeFirst;

public partial class Curso
{
    public int IdCurso { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<Aluno> IdAlunos { get; set; } = new List<Aluno>();
}
