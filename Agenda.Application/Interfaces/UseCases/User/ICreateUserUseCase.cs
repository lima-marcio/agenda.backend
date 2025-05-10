using Agenda.Application.DTOs;

namespace Agenda.Application.Interfaces.UseCases.User
{

  public interface ICreateUserUseCase
  {
    Task<UserDto> ExecuteAsync(UserDto user);
  }
}