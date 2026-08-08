using AdvancedWebApiDotnet.Configuration;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Database Configuration
builder.UseDatabaseConfiguration();

var app = builder.Build();

app.UseDatabaseMigrationConfiguration();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
