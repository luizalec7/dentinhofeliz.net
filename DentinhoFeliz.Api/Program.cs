using DentinhoFeliz.Infrastructure.Data;
using DentinhoFeliz.Infrastructure.Repositories;
using DentinhoFeliz.Application.Services;
using DentinhoFeliz.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuração do DbContext
builder.Services.AddDbContext<DentinhoFelizDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Injeção de dependência dos repositórios e serviços
builder.Services.AddScoped<ICriancaRepository, CriancaRepository>();
builder.Services.AddScoped<CriancaService>();

// Adiciona controladores à aplicação
builder.Services.AddControllers();

// Configurações de middleware
var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

app.Run();