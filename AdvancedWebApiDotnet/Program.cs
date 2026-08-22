using AdvancedWebApiDotnet.Configuration;
using AdvancedWebApiDotnet.Domain.Entities.People.Repository;
using AdvancedWebApiDotnet.Domain.Entities.People.Service;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Service;
using AdvancedWebApiDotnet.Infra.Repositories.People;
using AdvancedWebApiDotnet.Infra.Repositories.Posts;
using AdvancedWebApiDotnet.Infra.Services.People;
using AdvancedWebApiDotnet.Infra.Services.Posts;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

string appSettingsProfile = Environment.GetEnvironmentVariable("APIUSER");

if (!string.IsNullOrEmpty(appSettingsProfile))
{
    string appSettings = string.IsNullOrWhiteSpace(appSettingsProfile) ? "appsettings.Development.json" : $"appsettings.{appSettingsProfile}.json";

    builder.Configuration
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile(appSettings, optional: false, reloadOnChange: true)
        .AddEnvironmentVariables();
}




// Add services to the container.

builder.Services.AddTransient<IPeopleService, PeopleService>();
builder.Services.AddTransient<IPeopleRepository, PeopleRepository>();

builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IPostRepository, PostRepository>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Database Configuration
builder.UseDatabaseConfiguration();


builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler =
            ReferenceHandler.IgnoreCycles;
    });


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
