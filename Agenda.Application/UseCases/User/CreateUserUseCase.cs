using Agenda.Application.DTOs;
using Agenda.Application.Interfaces.UseCases.User;
using Agenda.Domain.Interfaces;

namespace Agenda.Application.UseCases.User
{
  public class CreateUserUseCase : ICreateUserUseCase
  {
    private readonly IUserRepository _repository;
    public CreateUserUseCase(IUserRepository repository, IGetUserByEmailUseCase getUserByEmailUseCase, IGetUserByIdUseCase getUserByIdUseCase)
    {
      _repository = repository;
    }

    public Task<UserDto> ExecuteAsync(UserDto user)
    {
      throw new NotImplementedException();
    }
  }
}
