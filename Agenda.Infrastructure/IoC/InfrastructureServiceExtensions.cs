using Agenda.Application.Interfaces;
using Agenda.Application.Interfaces.UseCases.Office;
using Agenda.Application.Services;
using Agenda.Application.UseCases.Office;
using Agenda.Domain.Interfaces;
using Agenda.Infrastructure.Data;
using Agenda.Infrastructure.Repositories;
using Agenda.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Agenda.Infrastructure.IoC
{
  public static class InfrastructureServiceExtensions
  {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
      services.AddDbContext<AgendaDbContext>(options =>
          options.UseSqlite(config.GetConnectionString("DefaultConnection")));

      services.AddScoped<ICreateOfficeUseCase, CreateOfficeUseCase>();
      services.AddScoped<IUpdateOfficeUseCase, UpdateOfficeUseCase>();
      services.AddScoped<IOfficeRepository, OfficeRepository>();
      services.AddScoped<IOfficeService, OfficeService>();


      return services;
    }
  }
}