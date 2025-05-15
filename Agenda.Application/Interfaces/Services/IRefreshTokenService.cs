using Agenda.Application.DTOs;

namespace Agenda.Application.Interfaces
{
  public interface IRefreshTokenService
  {
    Task<List<RefreshTokenDto>> GetAllAsync();
    Task<RefreshTokenDto?> GetByIdAsync(int id);
    Task<RefreshTokenDto> CreateAsync(RefreshTokenDto dto);
    Task<bool> UpdateAsync(RefreshTokenDto dto);
    Task<bool> DeleteAsync(int id);

  }
}