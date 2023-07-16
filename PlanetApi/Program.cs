using PlanetsApi.Models;
using Microsoft.EntityFrameworkCore;
using PlanetApi.QueryServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SqlAstronomyDb");
builder.Services.AddDbContext<AstronomyDbContext>(options =>
    options.UseSqlServer(connectionString)
);
builder.Services.AddScoped<IPlanetQueryService, PlanetQueryService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
