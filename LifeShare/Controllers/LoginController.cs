using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeShare.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeShare.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Autenticar(Login Admin)
        {
            // Redireciona diretamente para a próxima página, sem validação
            return Redirect("/Empresa/Index");
        }

        [HttpGet]
        public IActionResult Autenticar()
        {
            return View();
        }
    }
}
