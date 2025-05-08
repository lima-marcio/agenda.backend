using Agenda.Application.DTOs;

namespace Agenda.Interfaces
{
  public class UserService : IUserService
  {
    public Task<UserDto> CreateAsync(CreateUserDto dto)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<List<UserDto>> GetAllAsync()
    {
      throw new NotImplementedException();
    }

    public Task<UserDto?> GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<UserDto> GetUserByEmailAsync(string email)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(UserDto dto)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UserExistsAsync(string username, string email)
    {
      throw new NotImplementedException();
    }
  }
}