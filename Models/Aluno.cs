using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_exemplo.Models
{
    public class Aluno : Pessoa
    {
        public string Curso {get; set;}
        public virtual Turma AlunoTurma {get; set;}
    }
}