using Agenda.Application.DTOs;
using Agenda.Application.Responses;
using Agenda.Application.Interfaces;
using Agenda.Application.Interfaces.UseCases;

namespace Agenda.Application.UseCases.Office
{
  public class GetAllOfficesUseCase : IGetAllOfficesUseCase
  {
    private readonly IOfficeService _service;

    public GetAllOfficesUseCase(IOfficeService service)
    {
      _service = service;
    }

    public async Task<PagedResponse<OfficeDto>> ExecuteAsync(int page, int pageSize, Func<int, int, string> urlBuilder)
    {
      return await _service.GetPagedAsync(page, pageSize, urlBuilder);
    }
  }

  public interface IGetAllOfficesUseCase
  {
    Task<PagedResponse<OfficeDto>> ExecuteAsync(int page, int pageSize, Func<int, int, string> urlBuilder);
  }
}
