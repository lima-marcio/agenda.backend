using Agenda.Entities;

namespace Agenda.Domain.Interfaces;

public interface IUserRepository
{
  Task<User?> GetByEmailAsync(string email);
  Task AddAsync(User user);
}
