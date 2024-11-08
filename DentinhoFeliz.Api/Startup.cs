using DentinhoFeliz.Application.Services;
using DentinhoFeliz.Domain.Interfaces;
using DentinhoFeliz.Infrastructure.Data;
using DentinhoFeliz.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DentinhoFelizDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<ICriancaRepository, CriancaRepository>();
        services.AddScoped<CriancaService>();

        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}