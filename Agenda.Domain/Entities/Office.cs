namespace Agenda.Domain.Entities
{
  public class Office
  {
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int RoomNumber { get; set; } = 0;
  }
}