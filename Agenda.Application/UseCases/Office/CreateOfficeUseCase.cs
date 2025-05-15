using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using Agenda.Application.Interfaces.UseCases;

namespace Agenda.Application.UseCases.Office
{
  public class CreateOfficeUseCase : IUseCase<OfficeDto, OfficeDto>
  {
    private readonly IOfficeService _service;

    public CreateOfficeUseCase(IOfficeService service)
    {
      _service = service;
    }

    public async Task<OfficeDto> ExecuteAsync(OfficeDto dto)
    {
      return await _service.CreateAsync(dto);
    }
  }
}
