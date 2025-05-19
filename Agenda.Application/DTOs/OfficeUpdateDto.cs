namespace Agenda.Application.DTOs
{
  public class OfficeUpdateDto
  {
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int RoomNumber { get; set; } = 0;
  }
}