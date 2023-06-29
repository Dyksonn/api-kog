using APIWallet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIWallet.Infrastructure.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(prop => prop.Id) ;

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("TEXT");

            builder.Property(prop => prop.Nascimento)
               .HasConversion(prop => prop.ToString(), prop => DateTime.Parse(prop))
               .IsRequired()
               .HasColumnName("Nascimento")
               .HasColumnType("TEXT");

            builder.Property(prop => prop.CPF)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("CPF")
                .HasColumnType("TEXT");
        }
    }
}
