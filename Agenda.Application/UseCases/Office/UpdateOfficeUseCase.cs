using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using Agenda.Application.Interfaces.UseCases;

namespace Agenda.Application.UseCases.Office
{
  public class UpdateOfficeUseCase : IUseCase<OfficeDto, bool>
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
  }
}
