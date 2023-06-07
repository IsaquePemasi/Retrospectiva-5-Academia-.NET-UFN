using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst;

public partial class EDbfirstContext : DbContext
{
    public EDbfirstContext()
    {
    }

    public EDbfirstContext(DbContextOptions<EDbfirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=eDBFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.IdAluno).HasName("PK__Alunos__8D231D09CA206411");

            entity.Property(e => e.IdAluno)
                .ValueGeneratedNever()
                .HasColumnName("id_aluno");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasMany(d => d.IdCursos).WithMany(p => p.IdAlunos)
                .UsingEntity<Dictionary<string, object>>(
                    "Matricula",
                    r => r.HasOne<Curso>().WithMany()
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Matricula__id_cu__46E78A0C"),
                    l => l.HasOne<Aluno>().WithMany()
                        .HasForeignKey("IdAluno")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Matricula__id_al__45F365D3"),
                    j =>
                    {
                        j.HasKey("IdAluno", "IdCurso").HasName("PK__Matricul__B8F0EA59213EC555");
                        j.ToTable("Matriculas");
                        j.IndexerProperty<int>("IdAluno").HasColumnName("id_aluno");
                        j.IndexerProperty<int>("IdCurso").HasColumnName("id_curso");
                    });
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso).HasName("PK__Cursos__5D3F7502C9AE5B86");

            entity.Property(e => e.IdCurso)
                .ValueGeneratedNever()
                .HasColumnName("id_curso");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
