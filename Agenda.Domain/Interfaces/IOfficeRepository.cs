// Agenda.Domain.Interfaces
using Agenda.Domain.Entities;

namespace Agenda.Domain.Interfaces
{
  public interface IOfficeRepository
  {
    Task<List<Office>> GetAllAsync();
    Task<Office?> GetByIdAsync(int id);
    Task CreateAsync(Office office);
    Task<bool> UpdateAsync(Office office);
    Task<bool> DeleteAsync(int id);
    Task<List<Office>> GetPagedAsync(int page, int pageSize);
    Task<int> CountAsync();
  }
}
