using EnqueteWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EnqueteWeb.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet] //atributo
        public IActionResult Responder()
        {
            return View();
        }
        [HttpPost] //atributo
        public IActionResult Responder(Resposta resposta)
        {
            if (ModelState.IsValid)
            {
                Repositorio.AdicionarResposta(resposta);
                return View("Obrigado");
            }
            else
            {
                return View(resposta);
            }

        }
        public IActionResult Resultado()
        {
            return View(Repositorio.Respostas);
        }
    }
}
