using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_exemplo.Models
{
    public class Professor : Pessoa
    {
        public string Formacao {get; set;}
       public double Salario {get; set;}
       public virtual ICollection<Turma> ProfessorsTurmas {get;set;}
    }
}