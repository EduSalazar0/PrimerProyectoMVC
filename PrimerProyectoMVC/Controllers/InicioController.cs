using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimerProyectoMVC.Datos;
using PrimerProyectoMVC.Models;

namespace PrimerProyectoMVC.Controllers
{
    public class InicioController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public InicioController(ApplicationDbContext contexto) //Listo para utilizarlo en formularios y realizar request en el programa
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
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
