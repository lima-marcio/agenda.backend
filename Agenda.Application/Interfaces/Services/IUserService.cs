using Agenda.Application.DTOs;

namespace Agenda.Interfaces
{
  public interface IUserService
  {
    Task<List<UserDto>> GetAllAsync();
    Task<UserDto?> GetByIdAsync(int id);
    Task<UserDto> CreateAsync(CreateUserDto dto);
    Task<bool> UpdateAsync(UserDto dto);
    Task<bool> DeleteAsync(int id);
    Task<bool> UserExistsAsync(string username, string email);
    Task<UserDto> GetUserByEmailAsync(string email);
  }
}