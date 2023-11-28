using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet_exemplo.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) {

        }

        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Pessoa> Pessoas {get; set;}
        public DbSet<Aluno> Alunos {get; set;}
        public DbSet<Professor> Professores {get; set;}
        public DbSet<Turma> Turmas {get; set;}
    }
}