using DentinhoFeliz.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DentinhoFeliz.Infrastructure.Data
{
    public class DentinhoFelizDbContext : DbContext
    {
        public DentinhoFelizDbContext(DbContextOptions<DentinhoFelizDbContext> options) : base(options) { }

        public DbSet<Crianca> Criancas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DentinhoFelizDbContext).Assembly);
        }
    }
}