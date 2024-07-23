using ApiPeliculas.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base (options)
        {
        }

        //Aqui se pasan todos los Modelos
        public DbSet<Categoria> Categorias { get; set; }    
    }
}
