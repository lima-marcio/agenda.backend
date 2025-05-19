using Agenda.Application.UseCases.Office;
using Agenda.Application.Interfaces.UseCases;
using Agenda.Application.DTOs;
using FluentValidation;
using Agenda.Application.Validators.Office;

namespace Agenda.API.Extensions
{
  public static class UseCaseInjectionExtensions
  {
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
      services.AddScoped<IGetAllOfficesUseCase, GetAllOfficesUseCase>();
      services.AddScoped<IUseCase<int, OfficeDto?>, GetOfficeByIdUseCase>();
      // services.AddScoped<IUseCase<OfficeDto, OfficeDto>, CreateOfficeUseCase>();
      services.AddScoped<IUseCase<OfficeDto, bool>, UpdateOfficeUseCase>();
      services.AddScoped<IUseCase<int, bool>, DeleteOfficeUseCase>();

      services.AddScoped<CreateOfficeUseCase>();
      services.AddScoped<IValidator<OfficeCreateDto>, OfficeCreateValidator>();

      return services;
    }
  }
}
