using ControledeAula.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControledeAula.Models
{
    public class Aluno
    {
        private AlunoRepositorio alunorepo;

        public Aluno (int alunoId, string nome, 
            double nota1, double nota2, double nota3,
            double nota4, int faltas, string status)
        {
            AlunoId = alunoId;
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
            Faltas = faltas;
            Status = status;
        }
        public Aluno()
        {
            alunorepo = new AlunoRepositorio();
        }
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public double NotaTotal { 
            get {
                return (Nota1+Nota2+Nota3+Nota4) / 4;
            } }
        public int Faltas { get; set; }
        public string Situacao { get {
                if (NotaTotal <= 7 && Faltas >= 50)
                {
                    return "Aprovado";
                }
                else
                {
                    return "Reprovado";
                }
            } }
        public string Status { get; set; }

        public List<Aluno> RetornarAlunos()
        {
            return alunorepo.SelecionarAlunos();
        }
        public void IncluirAluno(Aluno aluno)
        {
            alunorepo.IncluirAluno(aluno);
        }
        public Aluno BuscarAluno(int alunoId)
        {
            return alunorepo.BuscarAluno(alunoId);
        }
        public void EditarAluno(Aluno aluno)
        {
            alunorepo.EditarAluno(aluno);
        }
        public void ExcluirAluno(int alunoId)
        {
            alunorepo.ExcluirAluno(alunoId);
        }

    }
}
