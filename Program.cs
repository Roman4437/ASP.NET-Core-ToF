using System.Reflection;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ToF.WebApi;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json")
    .Build();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    string connectionString = configuration.GetConnectionString("PostgreSQL");
    options.UseNpgsql(connectionString);
});

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddSwaggerGen(options =>
{
    string projectDirectory = AppContext.BaseDirectory;

    string projectName = Assembly.GetExecutingAssembly().GetName().Name;
    string xmlFilename = $"{projectName}.xml";

    options.IncludeXmlComments(Path.Combine(projectDirectory, xmlFilename));
});

builder.Services.AddControllers();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.MapControllers();

app.Run();