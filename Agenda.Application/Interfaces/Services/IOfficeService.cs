using Agenda.Application.DTOs;

namespace Agenda.Application.Interfaces
{
  public interface IOfficeService
  {
    Task<List<OfficeDto>> GetAllAsync();
    Task<OfficeDto?> GetByIdAsync(int id);
    Task<OfficeDto> CreateAsync(OfficeDto dto);
    Task<bool> UpdateAsync(OfficeDto dto);
    Task<bool> DeleteAsync(int id);

  }
}