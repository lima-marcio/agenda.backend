using Agenda.Application.DTOs;
using Agenda.Application.Responses.Results;

namespace Agenda.Application.Interfaces.UseCases.Office
{
  public interface ICreateOfficeUseCase
  {
    Task<Result> ExecuteAsync(OfficeCreateDto office);
  }
}