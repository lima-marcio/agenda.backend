using Agenda.Application.DTOs;
using Agenda.Application.Responses.Results;

namespace Agenda.Application.Interfaces.UseCases.User
{
  public interface ICreateUserUseCase
  {
    Task<Result> ExecuteAsync(UserDto user);
  }
}