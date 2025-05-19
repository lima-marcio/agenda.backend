using Agenda.Application.DTOs;
using Agenda.Application.Responses.Results;

namespace Agenda.Application.Interfaces.UseCases.Office
{
  public interface IUpdateOfficeUseCase
  {
    Task<Result> ExecuteAsync(OfficeUpdateDto office);
  }
}