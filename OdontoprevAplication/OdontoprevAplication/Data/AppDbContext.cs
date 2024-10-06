using Microsoft.EntityFrameworkCore;
using Odontoprev.Domain;  // Certifique-se de que está utilizando o namespace correto para suas entidades

namespace Odontoprev.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSet para a entidade Usuario
        public DbSet<Usuario> Usuarios { get; set; }

        // DbSet para outras entidades do projeto
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }

        // Configuração adicional de relacionamento e comportamento das entidades, se necessário
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aqui você pode configurar relacionamentos ou outras propriedades avançadas
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Fotos)
                .WithOne(f => f.Usuario)
                .HasForeignKey(f => f.UsuarioId); // Definir a chave estrangeira

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Notificacoes)
                .WithOne(n => n.Usuario)
                .HasForeignKey(n => n.UsuarioId); // Definir a chave estrangeira

            // Adicionar mais configurações se necessário
        }
    }
}
