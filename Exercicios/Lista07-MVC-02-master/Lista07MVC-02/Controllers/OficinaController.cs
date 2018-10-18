using Lista07MVC_02.Models;
using Lista07MVC_02.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lista07MVC_02.Controllers
{
    public class OficinaController : Controller
    {
        // GET: Oficina
        [HttpGet]
        public ActionResult Index()
        {
            List<ClientesModel> cliente = new ClientesRepository().GetAll();
            ViewBag.Clientes = cliente;

            return View();
        }
        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.Cliente = new ClientesModel();
            return View();
        }
        [HttpPost]
        public ActionResult Store(ClientesModel cliente)
        {
            if (ModelState.IsValid)
            {
                int identificador = new ClientesRepository().Register(cliente);
                return RedirectToAction("Index", new { id = identificador });
            }
            ViewBag.Cliente = cliente;
            return View("Cadastro");
        }
    }
}
