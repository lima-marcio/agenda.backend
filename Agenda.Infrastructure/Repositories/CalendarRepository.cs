using Agenda.Infrastructure.Data;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Infrastructure.Repositories
{
  public class CalendarRepository : ICalendarRepository
  {
    private readonly AgendaDbContext _context;

    public CalendarRepository(AgendaDbContext context)
    {
      _context = context;
    }
    public Task<bool> CalendarExistsAsync(string name, int userId)
    {
      throw new NotImplementedException();
    }

    public Task<Calendar?> CreateAsync(Calendar calendar)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<Calendar?> GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }
  }
}