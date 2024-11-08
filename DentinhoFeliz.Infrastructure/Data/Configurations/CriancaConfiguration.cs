using DentinhoFeliz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentinhoFeliz.Infrastructure.Data.Configurations
{
    public class CriancaConfiguration : IEntityTypeConfiguration<Crianca>
    {
        public void Configure(EntityTypeBuilder<Crianca> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.EmailResponsavel).IsRequired().HasMaxLength(100);
        }
    }
}