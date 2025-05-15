using Agenda.Domain.Entities;

namespace Agenda.Application.DTOs
{
  public class BusinessPartnerDto
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public eBusinessPartnerType PartnerType { get; set; } = eBusinessPartnerType.Client;
  }
}
