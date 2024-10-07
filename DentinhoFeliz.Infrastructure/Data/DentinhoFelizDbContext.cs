using Microsoft.EntityFrameworkCore;
using DentinhoFeliz.Domain.Entities;

namespace DentinhoFeliz.Infrastructure
{
    public class DentinhoFelizDbContext : DbContext
    {
        public DentinhoFelizDbContext(DbContextOptions<DentinhoFelizDbContext> options)
            : base(options)
        {
        }

        public DbSet<Crianca> Criancas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configurações adicionais de entidades aqui
        }
    }
}