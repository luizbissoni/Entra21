using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Nome = "Stolfinho";
            ViewBag.Idade = 16;
            return View();
        }
        public ActionResult Calculadora()
        {
            return View();
        }
        public ActionResult Calcular(int numero01, int numero02)
        {
            int some = numero01 + numero02;
            ViewBag.Numero01 = numero01;
            ViewBag.Numero02 = numero02;
            ViewBag.Soma = some;
            return View();
        }
    }
}