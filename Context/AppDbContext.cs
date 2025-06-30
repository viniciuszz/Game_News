using Microsoft.EntityFrameworkCore;
using Treino_Mvc.Models;

namespace Treino_MVC.Context
{//DbContext é uma classe do entityframeworkcore 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Noticia> Noticias { get; set; }
    }
}
