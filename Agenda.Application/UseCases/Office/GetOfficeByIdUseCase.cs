using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using Agenda.Application.Interfaces.UseCases;

namespace Agenda.Application.UseCases.Office
{
  public class GetOfficeByIdUseCase : IUseCase<int, OfficeDto?>
  {
    private readonly IOfficeService _service;

    public GetOfficeByIdUseCase(IOfficeService service)
    {
      _service = service;
    }

    public async Task<OfficeDto?> ExecuteAsync(int id)
    {
      return await _service.GetByIdAsync(id);
    }
  }
}
