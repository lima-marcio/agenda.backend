namespace Agenda.Application.DTOs
{
  public class CreateUserDto
  {
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
  }

}