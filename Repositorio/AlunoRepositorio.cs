using ControledeAula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControledeAula.Repositorio
{
    public class AlunoRepositorio
    {
        private List<Aluno> Alunos;

        private void AdicionaAluno()
        {
            Alunos = new List<Aluno>();
            Alunos.Add(new Aluno(
                1,
                "Camille",
                10,
                5,
                10,
                7,
                10,
                "Cusando"));
            Alunos.Add(new Aluno(
                2,
                "Ana",
                10,
                7,
                6,
                8,
                5,
                "Cusando"));
            Alunos.Add(new Aluno(
             3,
             "Giuliana",
             5,
             8,
             7,
             8,
             60,
             "Cusando"));
        }
        public AlunoRepositorio()
        {
            AdicionaAluno();
        }
        public List<Aluno> SelecionarAlunos()
        {
            return Alunos;
        }
        public void IncluirAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public Aluno BuscarAluno(int alunoId)
        {
            return Alunos.FirstOrDefault(a => a.AlunoId == alunoId);
        }
        public void EditarAluno(Aluno aluno)
        {
            var meuAluno = BuscarAluno(aluno.AlunoId);
            int indice = Alunos.IndexOf(meuAluno);
            Alunos[indice] = aluno;
        }
        public void ExcluirAluno(int alunoId)
        {
            Alunos.Remove(BuscarAluno(alunoId));
        }


    }
}
