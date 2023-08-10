using Microsoft.EntityFrameworkCore;
using TiendaServicio.Api.Autor.Modelo;

namespace TiendaServicio.Api.Autor.Persistencia
{
    public class ContextAutor : DbContext
    {
        public ContextAutor(DbContextOptions<ContextAutor> options) : base(options) { }

        public DbSet<AutorLibro> AutorLibro { get; set; }
        public DbSet<GradoAcademico> GradoAcademico { get; set; }
    }
}
