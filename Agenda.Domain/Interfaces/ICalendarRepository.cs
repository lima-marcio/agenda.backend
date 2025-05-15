using Agenda.Domain.Entities;

namespace Agenda.Domain.Interfaces
{
  public interface ICalendarRepository
  {
    Task<Calendar?> CreateAsync(Calendar calendar);
    Task<Calendar?> GetByIdAsync(int id);
    Task<bool> DeleteAsync(int id);
    Task<bool> CalendarExistsAsync(string name, int userId);
  }
}