using BrainBox.Domain.Common;
using BrainBox.Domain.Models;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrainBox.Infraestructure.Persistence.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id).HasConversion(
            ProductId => ProductId.Value,
            value => new BaseId(value)
        );
        builder.Property(p => p.Name).HasMaxLength(50);
        builder.Property(p => p.Description).HasMaxLength(100);
        builder.Property(p => p.Sku).HasMaxLength(100);
        builder.HasIndex(p => p.Sku);
        builder.Property(p => p.UniqueId).HasConversion(
            UniqueId => UniqueId.Value,
            value => new ProductUniqueId(value)
        );        
        builder.HasIndex(p => p.UniqueId);
        builder.Property(p => p.Barcode).HasConversion(
            Barcode => Barcode.Value,
            value => Upc.Create(value)!
        );
        builder.Property(p => p.Active);
    }
}
