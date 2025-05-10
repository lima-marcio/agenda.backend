namespace Agenda.Application.Interfaces.UseCases.User
{
  using Agenda.Application.DTOs;
  using Agenda.Application.Requests;

  public interface IUpdateUserUseCase
  {
    Task<UserDto> ExecuteAsync(UpdateUserRequest user);
  }
}