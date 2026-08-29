using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer.Configuration
{
    public class PeopleConfiguration : IEntityTypeConfiguration<PeopleModel>
    {
        public void Configure(EntityTypeBuilder<PeopleModel> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Document)
                    .HasMaxLength(200)
                    .IsRequired();

            builder
                .Property(x => x.FirstName)
                    .HasMaxLength(200)
                    .IsRequired();

            builder
                .Property(x => x.LastName)
                    .HasMaxLength(200)
                    .IsRequired();

            builder
                .HasMany(x => x.Posts)
                .WithOne(x => x.Persona);

            builder
                .ToTable("People");
        }
    }
}
