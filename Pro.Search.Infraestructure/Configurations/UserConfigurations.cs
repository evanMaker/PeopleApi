using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pro.Search.PersonDomains.PersonEngine.Entities;

namespace Pro.Search.Infraestructure.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("users").HasKey(p => new { p.Id });
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Username).HasColumnName("username").HasColumnType("VARCHAR2");
            builder.Property(p => p.Password).HasColumnName("password").HasColumnType("VARCHAR2");
            builder.Property(p => p.Role).HasColumnName("roles").HasColumnType("VARCHAR2");
        }
    }
}
