namespace Agenda.Application.Requests
{
  public class CreateUserRequest
  {
    public int Id { get; set; }
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
  }
}