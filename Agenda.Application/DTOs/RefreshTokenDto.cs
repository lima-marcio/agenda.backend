namespace Agenda.Application.DTOs
{
  public class RefreshTokenDto
  {
    public int Id { get; set; }
    public string Token { get; set; } = string.Empty;
    public DateTime ExpirationDate { get; set; } = DateTime.UtcNow.AddDays(7);
    public bool IsRevoked { get; set; } = false;
    public int UserId { get; set; }
  }
}