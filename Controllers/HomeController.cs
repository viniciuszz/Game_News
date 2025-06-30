using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Treino_MVC.Models;
using Treino_MVC.Repository.Interface;

namespace Treino_MVC.Controllers
{
    public class HomeController : Controller
    {
 
        private readonly INoticiaRepository _noticiaRepository;

        public HomeController(INoticiaRepository noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public IActionResult Index()
        {
            var listanoticias = _noticiaRepository.Noticias;

            return View(listanoticias);
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
