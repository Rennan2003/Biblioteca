using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Livro> Livros { get; set; }
    }
}
