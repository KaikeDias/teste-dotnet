﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dotnet_exemplo.Models;

#nullable disable

namespace dotnet_exemplo.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("dotnet_exemplo.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");
                });

            modelBuilder.Entity("dotnet_exemplo.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("integer");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("dotnet_exemplo.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProfessorTurma", b =>
                {
                    b.Property<int>("ProfessoresId")
                        .HasColumnType("integer");

                    b.Property<int>("ProfessorsTurmasId")
                        .HasColumnType("integer");

                    b.HasKey("ProfessoresId", "ProfessorsTurmasId");

                    b.HasIndex("ProfessorsTurmasId");

                    b.ToTable("ProfessorTurma");
                });

            modelBuilder.Entity("dotnet_exemplo.Models.Aluno", b =>
                {
                    b.HasBaseType("dotnet_exemplo.Models.Pessoa");

                    b.Property<int>("AlunoTurmaId")
                        .HasColumnType("integer");

                    b.Property<string>("Curso")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("AlunoTurmaId");

                    b.HasDiscriminator().HasValue("Aluno");
                });

            modelBuilder.Entity("dotnet_exemplo.Models.Professor", b =>
                {
                    b.HasBaseType("dotnet_exemplo.Models.Pessoa");

                    b.Property<string>("Formacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Salario")
                        .HasColumnType("double precision");

                    b.HasDiscriminator().HasValue("Professor");
                });

            modelBuilder.Entity("ProfessorTurma", b =>
                {
                    b.HasOne("dotnet_exemplo.Models.Professor", null)
                        .WithMany()
                        .HasForeignKey("ProfessoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_exemplo.Models.Turma", null)
                        .WithMany()
                        .HasForeignKey("ProfessorsTurmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet_exemplo.Models.Aluno", b =>
                {
                    b.HasOne("dotnet_exemplo.Models.Turma", "AlunoTurma")
                        .WithMany("Alunos")
                        .HasForeignKey("AlunoTurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AlunoTurma");
                });

            modelBuilder.Entity("dotnet_exemplo.Models.Turma", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
