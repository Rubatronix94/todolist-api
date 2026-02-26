using Microsoft.EntityFrameworkCore;

namespace todolist_api.Modelos
{
    public class TareasContext : DbContext
    {
        public TareasContext(DbContextOptions<TareasContext> options) : base(options)
        {
        }
        
        public DbSet<Tareas> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tareas>().HasIndex(c => c.titulo).IsUnique(); //ESTO EVITA QUE SE REPITAN
        }
    }
}
