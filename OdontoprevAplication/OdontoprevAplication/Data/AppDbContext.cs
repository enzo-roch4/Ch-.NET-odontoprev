
using Microsoft.EntityFrameworkCore;
using Odontoprev.Domain;
using System.Data.Entity;

namespace Odontoprev.Data
{
    public class AppDbContext : System.Data.Entity.DbContext
    {
    
        public required System.Data.Entity.DbSet<Usuario>? Usuarios { get; set; }
        public required System.Data.Entity.DbSet<Foto> Fotos { get; set; }
        public required System.Data.Entity.DbSet<Erro> Erros { get; set; }
        public required System.Data.Entity.DbSet<Processo> Processos { get; set; }
        public required System.Data.Entity.DbSet<Notificacao> Notificacoes { get; set; }
        public required System.Data.Entity.DbSet<Sair> Sair { get; set; }

        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Usuario>().ToTable("Usuarios");
        //    modelBuilder.Entity<Foto>().ToTable("Fotos");
        //    modelBuilder.Entity<Erro>().ToTable("Erros");
        //    modelBuilder.Entity<Processo>().ToTable("Processos");
        //    modelBuilder.Entity<Notificacao>().ToTable("Notificacoes");
        //    modelBuilder.Entity<Sair>().ToTable("Sair");
        //}
    }
}
