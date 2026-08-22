using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer
{
    public class SqlServerContext : DbContext
    {
        public DbSet<PeopleModel> People { get; set; }

        public DbSet<PostModel> Posts { get; set; }

        public SqlServerContext()
        {
        }

        public SqlServerContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Corporation;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
