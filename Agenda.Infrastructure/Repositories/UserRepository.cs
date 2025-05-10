using Agenda.Data;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Infrastructure.Repositories
{
  public class UserRepository : IUserRepository
  {
    private readonly AgendaDbContext _context;

    public UserRepository(AgendaDbContext context)
    {
      _context = context;
    }

    public Task<User?> CreateAsync(User user)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<User?> GetByEmailAsync(string email)
    {
      throw new NotImplementedException();
    }

    public Task<User?> GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(User user)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UserExistsAsync(string username, string email)
    {
      throw new NotImplementedException();
    }
  }
}