using ExemploMVC02.Database;
using ExemploMVC02.Models;
using ExemploMVC02.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC02.Controllers
{
    public class RecrutadoraController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<Recrutadora> recrutadoras = new RecrutadoraRepository().ObterTodos();
            ViewBag.Recrutadoras = recrutadoras;
            ViewBag.TituloPagina = "Recrutadoras";
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Recrutadoras - Cadastro";
            ViewBag.Recrutadora = new Recrutadora();
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Recrutadora recrutadora = new RecrutadoraRepository().ObterPeloId(id);
            ViewBag.Recrutadora = recrutadora;
            return View();
        }

        [HttpPost]
        public ActionResult Store(Recrutadora recrutadora)
        {
            if (ModelState.IsValid)
            {
                recrutadora.CPF = recrutadora.CPF.Replace(".", "").Replace("-", "");
                int identificador = new RecrutadoraRepository().Cadastrar(recrutadora);
                return RedirectToAction("Editar", new { id = identificador });
            }
            ViewBag.Recrutadora = recrutadora;
            return View("Cadastro");

        }

        [HttpPost]
        public ActionResult Update(Recrutadora recrutadora)
        {
            bool alterado = new RecrutadoraRepository().Alterar(recrutadora);
            return null;
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new RecrutadoraRepository().Excluir(id);
            return null;
        }
    }
}