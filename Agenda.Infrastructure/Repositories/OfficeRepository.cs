// Agenda.Infrastructure.Repositories
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;
using Agenda.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Infrastructure.Repositories
{
  public class OfficeRepository : IOfficeRepository
  {
    private readonly AgendaDbContext _context;

    public OfficeRepository(AgendaDbContext context)
    {
      _context = context;
    }

    public async Task AddAsync(Office office)
    {
      _context.Offices.Add(office);
      await _context.SaveChangesAsync();
    }

    public async Task<List<Office>> GetAllAsync()
    {
      return await _context.Offices.ToListAsync();
    }

    public async Task<Office?> GetByIdAsync(int id)
    {
      return await _context.Offices.FindAsync(id);
    }

    public async Task CreateAsync(Office office)
    {
      _context.Offices.Add(office);
      await _context.SaveChangesAsync();
    }

    public async Task<bool> UpdateAsync(Office office)
    {
      _context.Offices.Update(office);
      return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var office = await _context.Offices.FindAsync(id);
      if (office == null) return false;

      _context.Offices.Remove(office);
      return await _context.SaveChangesAsync() > 0;
    }

    public async Task<List<Office>> GetPagedAsync(int page, int pageSize)
    {
      return await _context.Offices
        .OrderBy(o => o.Description)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();
    }

    public async Task<int> CountAsync()
    {
      return await _context.Offices.CountAsync();
    }

    public async Task<bool> ExistsByRoomNumberAsync(int id)
    {
      return await _context.Offices.AnyAsync(o => o.RoomNumber == id);
    }
  }
}