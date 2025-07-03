using System.ComponentModel.DataAnnotations.Schema;

namespace Treino_MVC.Models
{
    [Table("Autores")]
    public class Autor
    {
        public int AutorId { get; set; }
        public string NomeAutor { get; set; }
        public string EmailAutor { get; set; }
        public DateOnly DataDeNasc { get; set; }
        public int SenhaAutor { get; set; }
    }
}
