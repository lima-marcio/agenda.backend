using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using Agenda.Application.Interfaces.UseCases;
using Agenda.Application.Interfaces.UseCases.Office;
using Agenda.Application.Responses.Results;

namespace Agenda.Application.UseCases.Office
{
  public class UpdateOfficeUseCase : IUpdateOfficeUseCase
  {
    private readonly IOfficeService _service;

    public UpdateOfficeUseCase(IOfficeService service)
    {
      _service = service;
    }

    public async Task<bool> ExecuteAsync(OfficeDto dto)
    {
      return await _service.UpdateAsync(dto);
    }

    public Task<Result> ExecuteAsync(OfficeUpdateDto office)
    {
      throw new NotImplementedException();
    }
  }
}
