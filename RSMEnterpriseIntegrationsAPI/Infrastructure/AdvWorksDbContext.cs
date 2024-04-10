﻿namespace RSMEnterpriseIntegrationsAPI.Infrastructure
{
    using Microsoft.EntityFrameworkCore;

    using RSMEnterpriseIntegrationsAPI.Domain.Models;

    using System.Reflection;

    public class AdvWorksDbContext : DbContext
    {
        public AdvWorksDbContext()
        {
        }

        public AdvWorksDbContext(DbContextOptions<AdvWorksDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departament> Departments { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Departament> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
