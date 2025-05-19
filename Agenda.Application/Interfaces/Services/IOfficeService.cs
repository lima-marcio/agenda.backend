using Agenda.Application.DTOs;
using Agenda.Application.Responses;

namespace Agenda.Application.Interfaces
{
  public interface IOfficeService
  {
    Task<List<OfficeDto>> GetAllAsync();
    Task<OfficeDto?> GetByIdAsync(int id);
    Task<OfficeDto> CreateAsync(OfficeCreateDto dto);
    Task<bool> UpdateAsync(OfficeDto dto);
    Task<bool> DeleteAsync(int id);
    Task<PagedResponse<OfficeDto>> GetPagedAsync(int page, int pageSize, Func<int, int, string> urlBuilder);
  }
}