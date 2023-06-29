using APIWallet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIWallet.Infrastructure.Data.Mapping
{
    public class WalletMap : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable("Wallets");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.UserID)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("INTEGER");

            builder.Property(prop => prop.ValorAtual)
                .HasConversion(prop => prop, prop => prop)
                .IsRequired()
                .HasColumnName("ValorAtual")
                .HasColumnType("REAL");

            builder.Property(prop => prop.Banco)
                .IsRequired()
                .HasColumnName("Banco")
                .HasColumnType("TEXT");

            builder.Property(prop => prop.UltimaAtualizacao)
                .HasConversion(prop => prop.ToString(), prop => DateTime.Parse(prop))
                .IsRequired()
                .HasColumnName("UltimaAtualizacao")
                .HasColumnType("TEXT");
        }
       
    }
}
