namespace Agenda.Application.DTOs
{
  public class CalendarDto
  {
    public int Id { get; set; } = 0;
    public int UserId { get; set; } = 0;
    public int BusinessPartnerId { get; set; } = 0;
    public int OfficeId { get; set; } = 0;
    public DateTime ReservationDateTime { get; set; } = DateTime.UtcNow;
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
  }
}