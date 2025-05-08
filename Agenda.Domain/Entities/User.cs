namespace Agenda.Entities
{
  public class User
  {
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Rule { get; set; } = string.Empty;
  }
}
