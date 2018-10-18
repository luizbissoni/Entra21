using Lista07MVC.Models;
using Lista07MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lista07MVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        [HttpGet]
        public ActionResult Index()
        {
            List<Alunos> alunos = new AlunoRepository().ObeterTodos();
            ViewBag.Alunos = alunos;
            ViewBag.TituloPagina = "Lista Alunos";

            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Cadastro";
            ViewBag.Aluno = new Alunos();
            return View();
        }

        [HttpPost]
        public ActionResult Store(Alunos aluno)
        {
            if (ModelState.IsValid)
            {
                //Replace nas notas e frequencia
                int identificador = new AlunoRepository().Cadastrar(aluno);
                return RedirectToAction("index", new { id = identificador });
            }
            ViewBag.Aluno = aluno;
            return View("Cadastro");
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new AlunoRepository().Excluir(id);
            return null;
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Alunos aluno = new AlunoRepository().ObterPeloId(id);
            ViewBag.Aluno = aluno;
            return View();
        }

        [HttpPost]
        public ActionResult Update(Alunos aluno)
        {
            bool alterado = new AlunoRepository().Alterar(aluno);

            if (alterado)
            {
                return RedirectToAction("Index");
            }
            return null;
        }
    }
}