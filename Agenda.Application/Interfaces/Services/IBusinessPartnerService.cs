using Agenda.Application.DTOs;
using Agenda.Domain.Entities;

namespace Agenda.Application.Interfaces
{
  public interface IBusinessPartnerService
  {
    Task<List<BusinessPartnerDto>> GetAllAsync();
    Task<BusinessPartnerDto?> GetByIdAsync(int id);
    Task<BusinessPartnerDto> CreateAsync(BusinessPartnerDto dto);
    Task<bool> UpdateAsync(BusinessPartnerDto dto);
    Task<bool> DeleteAsync(int id);
    Task<bool> BusinessPartnerExistsAsync(string name, string email, eBusinessPartnerType type);
  }
}