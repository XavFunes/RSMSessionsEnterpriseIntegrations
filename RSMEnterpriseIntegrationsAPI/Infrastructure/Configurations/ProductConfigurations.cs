namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RSMEnterpriseIntegrationsAPI.Domain.Models;
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product), "Production");

            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductId).HasColumnName("ProductID");
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.ProductNumber).IsRequired();
            builder.Property(p => p.MakeFlag).IsRequired();
            builder.Property(p => p.FinishedGoodsFlag).IsRequired();
            builder.Property(p => p.Color);
            builder.Property(p => p.SafetyStockLevel).IsRequired();
            builder.Property(p => p.ReorderPoint).IsRequired();
            builder.Property(p => p.StandardCost).IsRequired();
            builder.Property(p => p.ListPrice).IsRequired();
            builder.Property(p => p.Size).IsRequired();
        }
    }
}
