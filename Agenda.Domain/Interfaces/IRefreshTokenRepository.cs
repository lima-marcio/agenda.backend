using Agenda.Domain.Entities;

namespace Agenda.Domain.Interfaces
{
  public interface IRefreshTokenRepository
  {
    Task<RefreshToken?> CreateAsync(RefreshToken refreshToken);
    Task<RefreshToken?> GetByIdAsync(int id);
    Task<bool> DeleteAsync(int id);
    Task<bool> UpdateAsync(RefreshToken refreshToken);
    Task<bool> RefreshTokenExistsAsync(string token, int userId);
  }
}