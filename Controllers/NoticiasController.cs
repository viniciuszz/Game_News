using Microsoft.AspNetCore.Identity;
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

        public IActionResult NoticiaCompleta(int noticiaId)
        {
            var noticia = _noticiaRepository.Noticias.FirstOrDefault(t => t.NoticiaId == noticiaId);
            return View(noticia);
        }
    }
}
