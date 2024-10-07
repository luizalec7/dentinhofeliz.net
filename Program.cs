using DentinhoFeliz.Application.Services;
using DentinhoFeliz.Domain.Interfaces;
using DentinhoFeliz.Infrastructure.Data;
using DentinhoFeliz.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do DbContext
builder.Services.AddDbContext<DentinhoFeliz.Infrastructure.DentinhoFelizDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Inje��o de depend�ncia dos reposit�rios e servi�os
builder.Services.AddScoped<ICriancaRepository, CriancaRepository>();
builder.Services.AddScoped<CriancaService>();

// Adiciona controladores � aplica��o
builder.Services.AddControllers();

var app = builder.Build();

// Configura��es de middleware
app.UseAuthorization();
app.MapControllers();

app.Run();
