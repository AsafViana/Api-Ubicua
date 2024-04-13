using Api_Ubicua.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Ubicua.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Remova a configuração de dados iniciais para o Id do usuário
            //modelBuilder.Entity<Usuario>().Property(u => u.Id).ValueGeneratedOnAdd();

            // Outras configurações podem permanecer aqui, se houver

            base.OnModelCreating(modelBuilder);
        }
    }
}
