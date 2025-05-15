using Agenda.Infrastructure.Data;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Infrastructure.Repositories
{
  public class RefreshTokenRepository : IRefreshTokenRepository
  {
    private readonly AgendaDbContext _context;

    public RefreshTokenRepository(AgendaDbContext context)
    {
      _context = context;
    }

    public Task<RefreshToken?> CreateAsync(RefreshToken refreshToken)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<RefreshToken?> GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<bool> RefreshTokenExistsAsync(string token, int userId)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(RefreshToken refreshToken)
    {
      throw new NotImplementedException();
    }
  }
}