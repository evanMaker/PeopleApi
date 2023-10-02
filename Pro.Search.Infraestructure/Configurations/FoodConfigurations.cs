using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pro.Search.PersonDomains.PersonEngine.Entities;

namespace Pro.Search.Infraestructure.Configurations
{
    public class FoodConfigurations : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("food").HasKey(p => new { p.Id_Food });
            builder.Property(p => p.Id_Food).HasColumnName("id_food").HasColumnType("VARCHAR2");
            builder.Property(p => p.Name_Food).HasColumnName("name_food").HasColumnType("VARCHAR2");
            builder.Property(p => p.Locale_Purcache_Food).HasColumnName("locale_purcache_food").HasColumnType("VARCHAR2");
            builder.Property(p => p.Id_Pessoas_References).HasColumnName("id_pessoas_references").HasColumnType("VARCHAR2");
            builder.Property(p => p.Price_Food).HasColumnName("price_food").HasColumnType("DECIMAL");
            builder.HasOne<Persons>().WithMany(f => f.ComidaComprada).HasForeignKey(p => p.Id_Pessoas_References);
        }
    }
}
