namespace Agenda.Application.Interfaces.UseCases.User
{
  public interface IDeleteUserUseCase
  {
    Task<bool> ExecuteAsync(int id);
  }
}