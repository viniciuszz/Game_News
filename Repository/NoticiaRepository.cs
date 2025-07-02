using Treino_Mvc.Models;
using Treino_MVC.Context;
using Treino_MVC.Repository.Interface;

namespace Treino_MVC.Repository
{
    public class NoticiaRepository : INoticiaRepository
    {
        public  AppDbContext _context;

        public NoticiaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Noticia> Noticias => _context.Noticias;

        public Noticia GetNoticiaById(int noticiaId)
        {
            return _context.Noticias.FirstOrDefault(t => t.NoticiaId == noticiaId);
        }
    }
}
