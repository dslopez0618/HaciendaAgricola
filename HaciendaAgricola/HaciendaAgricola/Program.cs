using HaciendaAgricola.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HaciendaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("HaciendaDb")));

var app = builder.Build();

app.MapGet("/", () => "Hacienda Agrícola API");
app.Run();