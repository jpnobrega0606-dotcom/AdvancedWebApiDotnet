using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer.Configuration
{
    public class CommentsConfiguration : IEntityTypeConfiguration<CommentsModel>
    {
        public void Configure(EntityTypeBuilder<CommentsModel> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.CreatedDate)
                .IsRequired();

            builder
                .Property(x => x.LastUpdatedDate)
                .IsRequired(false);

            builder
                .Property(x => x.Description)
                .HasMaxLength(500)
                .IsRequired();

            builder
                .HasOne(x => x.People)
                .WithOne();

            builder
                .HasOne(x => x.Post)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .ToTable("Comments");
        }
    }
}
