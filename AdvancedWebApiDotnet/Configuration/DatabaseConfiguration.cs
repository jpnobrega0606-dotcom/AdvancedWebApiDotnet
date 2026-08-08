using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace AdvancedWebApiDotnet.Configuration
{
    public static class DatabaseConfiguration
    {
        public static void UseDatabaseConfiguration(this WebApplicationBuilder builder) 
        {
            builder.Services.AddDbContext<SqlServerContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Development"));
            });
        }

        public static void UseDatabaseMigrationConfiguration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                SqlServerContext dbContext = serviceScope.ServiceProvider.GetRequiredService<SqlServerContext>();
                dbContext.Database.Migrate();
            }
        }
    }
}
