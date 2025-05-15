using Agenda.Application.Interfaces;
using Agenda.Application.Interfaces.UseCases;

namespace Agenda.Application.UseCases.Office
{
  public class DeleteOfficeUseCase : IUseCase<int, bool>
  {
    private readonly IOfficeService _service;

    public DeleteOfficeUseCase(IOfficeService service)
    {
      _service = service;
    }

    public async Task<bool> ExecuteAsync(int id)
    {
      return await _service.DeleteAsync(id);
    }
  }
}
