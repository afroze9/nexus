﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.CompanyAPI.Entities;

namespace Nexus.CompanyAPI.Data.Configuration;

/// <summary>
///     Implements the entity type configuration for the <see cref="Company" /> entity.
/// </summary>
[ExcludeFromCodeCoverage]
public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    /// <summary>
    ///     Configures the entity type and its relationships.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        // Configures the maximum length and requirement of the company name.
        builder.Property(c => c.Name)
            .HasMaxLength(255)
            .IsRequired();

        // Configures the table name for the company entity.
        builder.ToTable("Company");

        // Configures a many-to-many relationship between the company and tag entities.
        builder
            .HasMany<Tag>(c => c.Tags)
            .WithMany(t => t.Companies)
            .UsingEntity("CompanyTag", typeof(Dictionary<string, object>),
                right => right.HasOne(typeof(Tag)).WithMany().HasForeignKey("TagId"),
                left => left.HasOne(typeof(Company)).WithMany().HasForeignKey("CompanyId"));
    }
}
