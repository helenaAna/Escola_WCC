using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControledeAula.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControledeAula.Controllers
{
    public class AlunoController : Controller
    {
        Aluno aluno;

        public AlunoController()
        {
            aluno = new Aluno();
        }

        // GET: Aluno
        public ActionResult Index()
        {
            return View(aluno.RetornarAlunos() ?? new List<Aluno>());
        }

        // GET: Aluno/Details/5
        public ActionResult Details(int alunoId)
        {
            return View(aluno.BuscarAluno(alunoId) ?? new Aluno());
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno aluno)
        {
            try
            {
                aluno.IncluirAluno(aluno);
                return View("Index", aluno.RetornarAlunos());
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(int alunoId)
        {
            return View(aluno.BuscarAluno(alunoId) ?? new Aluno());
            
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Aluno aluno)
        {
            try
            {
                aluno.EditarAluno(aluno);
                return View("Index", aluno.RetornarAlunos());
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(int alunoId)
        {
            aluno.ExcluirAluno(alunoId);
            return View("Index", aluno.RetornarAlunos());
        }
        
    }
}