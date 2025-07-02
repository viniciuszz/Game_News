using Treino_Mvc.Models;

namespace Treino_MVC.Repository.Interface
{
    public interface INoticiaRepository
    {
        IEnumerable<Noticia> Noticias { get; }
         Noticia GetNoticiaById(int noticiaId);
    }
}
