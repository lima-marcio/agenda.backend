using Agenda.Application.DTOs;

namespace Agenda.Application.Interfaces.UseCases.User
{

  public interface IGetUserByIdUseCase
  {
    Task<UserDto> ExecuteAsync(int id);
  }
}