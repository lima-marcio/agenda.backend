using Agenda.Domain.Entities;

namespace Agenda.Domain.Interfaces
{
  public interface IUserRepository
  {
    Task<User?> CreateAsync(User user);
    Task<User?> GetByEmailAsync(string email);
    Task<User?> GetByIdAsync(int id);
    Task<bool> DeleteAsync(int id);
    Task<bool> UpdateAsync(User user);
    Task<bool> UserExistsAsync(string username, string email);
  }
}