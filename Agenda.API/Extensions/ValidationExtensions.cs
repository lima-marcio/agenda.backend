using Agenda.Application.Validators.Office;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Agenda.API.Extensions
{
  public static class ValidationExtensions
  {
    public static IServiceCollection AddValidation(this IServiceCollection services)
    {
      // services.AddFluentValidationAutoValidation();
      services.AddValidatorsFromAssemblyContaining<OfficeCreateValidator>();

      return services;
    }
  }
}
