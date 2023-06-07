using System;
using System.Collections.Generic;

namespace CodeFirst;

public partial class Aluno
{
    public int IdAluno { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Curso> IdCursos { get; set; } = new List<Curso>();
}
