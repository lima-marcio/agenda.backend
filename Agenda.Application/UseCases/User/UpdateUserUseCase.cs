using Agenda.Application.DTOs;
using Agenda.Application.Interfaces.UseCases.User;
using Agenda.Application.Requests;
using Agenda.Domain.Interfaces;

namespace Agenda.Application.UseCases.User
{
  public class UpdateUserUseCase : IUpdateUserUseCase
  {
    private readonly IUserRepository _repository;
    public UpdateUserUseCase(IUserRepository repository, IGetUserByEmailUseCase getUserByEmailUseCase, IGetUserByIdUseCase getUserByIdUseCase)
    {
      _repository = repository;
    }

    public Task<UserDto> ExecuteAsync(UpdateUserRequest user)
    {
      throw new NotImplementedException();
    }
  }
}