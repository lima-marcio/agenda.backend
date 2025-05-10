using Agenda.Application.DTOs;

namespace Agenda.Application.Interfaces.UseCases.User
{
  public interface IGetUserByEmailUseCase
  {
    Task<UserDto> ExecuteAsync(string email);
  }
}