using Agenda.Application.DTOs;

namespace Agenda.Application.Interfaces
{
  public interface ICalendarService
  {
    Task<List<CalendarDto>> GetAllAsync();
    Task<CalendarDto?> GetByIdAsync(int id);
    Task<CalendarDto> CreateAsync(CalendarDto dto);
    Task<bool> UpdateAsync(CalendarDto dto);
    Task<bool> DeleteAsync(int id);

  }
}