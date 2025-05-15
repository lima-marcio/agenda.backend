namespace Agenda.Application.Interfaces.UseCases
{
  public interface IUseCase<TRequest, TResponse>
  {
    Task<TResponse> ExecuteAsync(TRequest request);
  }
}
