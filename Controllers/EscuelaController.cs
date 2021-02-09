using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net.Models;

namespace platzi_asp_net.Controllers
{
    public class EscuelaController : Controller
    {

        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoFundacion = 2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            return View(escuela);
        }

    }
}

