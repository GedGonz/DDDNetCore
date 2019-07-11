using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DDDNetCore.Models;
using Dominio.Servicios;
using Dominio.Contratos;

namespace DDDNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonaDB1DominioServicio personaDB1DominioServicio;
        private readonly IUniadadTrabajoAngenda uniadadTrabajoAngenda;
        public HomeController(IPersonaDB1DominioServicio personaDB1DominioServicio, IUniadadTrabajoAngenda uniadadTrabajoAngenda)
        {
            this.personaDB1DominioServicio = personaDB1DominioServicio;
            this.uniadadTrabajoAngenda = uniadadTrabajoAngenda;
        }
        public IActionResult Index()
        {
            var data=personaDB1DominioServicio.Obteneristado();
            var data2 = uniadadTrabajoAngenda.tareaRepositorio.Lista();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
