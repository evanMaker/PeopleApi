using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pro.Search.PersonDomains.PersonEngine.Entities;

namespace Pro.Search.Infraestructure.Configurations
{
    public class PersonsConfigurations : IEntityTypeConfiguration<Persons>
    {
        public void Configure(EntityTypeBuilder<Persons> builder)
        {
            builder.ToTable("pessoas");
            builder.Property(p => p.Id_Pessoas).HasColumnName("id_pessoas").HasColumnType("VARCHAR(255)");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("VARCHAR(255)");
            builder.Property(p => p.Sobrenome).HasColumnName("sobrenome").HasColumnType("VARCHAR(255)");
            builder.Property(p => p.Email).HasColumnName("email").HasColumnType("VARCHAR(255)");
            builder.Property(p => p.DataHora).HasColumnName("data_hora").HasColumnType("DATE");
            builder.Property(p => p.Pessoas_Calc_Number).HasColumnName("pessoas_calc_number").HasColumnType("INTEGER");
        }
    }
}
