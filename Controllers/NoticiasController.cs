using Microsoft.AspNetCore.Mvc;
using Treino_MVC.Repository.Interface;

namespace Treino_MVC.Controllers
{
    public class NoticiasController : Controller
    {
        private readonly INoticiaRepository _noticiaRepository;

        public NoticiasController(INoticiaRepository noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public IActionResult List()
        {
            var listanoticias = _noticiaRepository.Noticias;

            return View(listanoticias);
        }
    }
}
