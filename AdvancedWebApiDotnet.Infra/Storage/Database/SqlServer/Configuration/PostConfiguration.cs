using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<PostModel>
    {
        public void Configure(EntityTypeBuilder<PostModel> builder)
        {

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Title)
                    .HasMaxLength(200)
                    .IsRequired();

            builder
                .Property(x => x.Description)
                    .HasMaxLength(1000)
                    .IsRequired();

            builder
                .Property(x => x.Datetime)
                .IsRequired();

            builder
                .HasOne(x => x.Persona)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.PeopleId);

            builder
                .ToTable("Posts");
        }
    }
}
