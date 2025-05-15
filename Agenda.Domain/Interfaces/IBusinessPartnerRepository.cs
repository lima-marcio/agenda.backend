using Agenda.Domain.Entities;

namespace Agenda.Domain.Interfaces
{
  public interface IBusinessPartnerRepository
  {
    Task<BusinessPartner?> CreateAsync(BusinessPartner businessPartner);
    Task<BusinessPartner?> GetByIdAsync(int id);
    Task<bool> DeleteAsync(int id);
    Task<bool> UpdateAsync(BusinessPartner businessPartner);
    Task<bool> BusinessPartnerExistsAsync(string name, eBusinessPartnerType type);
  }
}