using Agenda.Infrastructure.Data;
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

      // services.AddCustomServices();

      return services;
    }
  }
}