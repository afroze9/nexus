﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.CompanyAPI.Entities;

namespace Nexus.CompanyAPI.Data.Configuration;

/// <summary>
///     Entity framework configuration for the <see cref="Tag" /> entity.
/// </summary>
[ExcludeFromCodeCoverage]
public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    /// <summary>
    ///     Configures the entity framework for the <see cref="Tag" /> entity.
    /// </summary>
    /// <param name="builder">The entity type builder.</param>
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.Property(t => t.Name)
            .HasMaxLength(20)
            .IsRequired();

        builder.ToTable("Tag");

        builder
            .HasMany<Company>(t => t.Companies)
            .WithMany(c => c.Tags)
            .UsingEntity("CompanyTag", typeof(Dictionary<string, object>),
                right => right.HasOne(typeof(Company)).WithMany().HasForeignKey("CompanyId"),
                left => left.HasOne(typeof(Tag)).WithMany().HasForeignKey("TagId"));
    }
}