using BibliotecaAeronautica.Entities;
using Microsoft.EntityFrameworkCore;


namespace BibliotecaAeronautica.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Aeroporto> Aeroporto { get; set; }

        public DbSet<Assento> Assentos { get; set; }

        public DbSet<Aviao> Avioes { get; set; }

        public DbSet<Bilhete> Bilhetes { get; set; }

        public DbSet<Voo> Voos { get; set; }


        public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    }
}
