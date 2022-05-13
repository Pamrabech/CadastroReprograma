using cadastroreprograma.Model;
using Microsoft.EntityFrameworkCore;

namespace cadastroreprograma.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario = modelBuilder.Entity<Usuario>();
            usuario.ToTable("tb_usuario");
            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Nome).HasColumnName("Nome").IsRequired();
            usuario.Property(x => x.Email).HasColumnName("Email");
        }
    }
}
