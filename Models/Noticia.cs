using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Treino_Mvc.Models
{
    [Table("Noticias")]
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }
        public DateTime DataDaNoticia { get; set; }
        public int AutorId { get; set; }



    }
}
