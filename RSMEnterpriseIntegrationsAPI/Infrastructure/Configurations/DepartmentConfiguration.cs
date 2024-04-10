namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using RSMEnterpriseIntegrationsAPI.Domain.Models;

    public class DepartmentConfiguration : IEntityTypeConfiguration<Departament>
    {
        public void Configure(EntityTypeBuilder<Departament> builder)
        {
            builder.ToTable(nameof(Departament), "HumanResources");

            builder.HasKey(e => e.DepartmentId);
            builder.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.GroupName).IsRequired();
        }
    }
}
