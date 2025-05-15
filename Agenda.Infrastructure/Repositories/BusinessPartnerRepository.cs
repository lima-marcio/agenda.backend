using Agenda.Infrastructure.Data;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Infrastructure.Repositories
{
  public class BusinessPartnerRepository : IBusinessPartnerRepository
  {
    private readonly AgendaDbContext _context;

    public BusinessPartnerRepository(AgendaDbContext context)
    {
      _context = context;
    }

    public Task<bool> BusinessPartnerExistsAsync(string name, eBusinessPartnerType type)
    {
      throw new NotImplementedException();
    }

    public Task<BusinessPartner?> CreateAsync(BusinessPartner businessPartner)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<BusinessPartner?> GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(BusinessPartner businessPartner)
    {
      throw new NotImplementedException();
    }
  }

}