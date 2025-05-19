// Agenda.Application.Services
using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using Agenda.Application.Responses;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Application.Services
{
  public class OfficeService : IOfficeService
  {
    private readonly IOfficeRepository _repository;

    public OfficeService(IOfficeRepository repository)
    {
      _repository = repository;
    }

    public async Task<List<OfficeDto>> GetAllAsync()
    {
      var offices = await _repository.GetAllAsync();
      return offices.Select(o => new OfficeDto
      {
        Id = o.Id,
        Description = o.Description,
        RoomNumber = o.RoomNumber
      }).ToList();
    }

    public async Task<OfficeDto?> GetByIdAsync(int id)
    {
      var office = await _repository.GetByIdAsync(id);
      if (office == null) return null;

      return new OfficeDto
      {
        Id = office.Id,
        Description = office.Description,
        RoomNumber = office.RoomNumber
      };
    }

    public async Task<OfficeDto> CreateAsync(OfficeDto dto)
    {
      var office = new Office
      {
        Description = dto.Description,
        RoomNumber = dto.RoomNumber
      };

      await _repository.CreateAsync(office);
      dto.Id = office.Id;
      return dto;
    }

    public async Task<bool> UpdateAsync(OfficeDto dto)
    {
      var office = await _repository.GetByIdAsync(dto.Id);
      if (office == null) return false;

      office.Description = dto.Description;
      office.RoomNumber = dto.RoomNumber;

      return await _repository.UpdateAsync(office);
    }

    public async Task<bool> DeleteAsync(int id)
    {
      return await _repository.DeleteAsync(id);
    }
    public async Task<PagedResponse<OfficeDto>> GetPagedAsync(int page, int pageSize, Func<int, int, string> urlBuilder)
    {
      var offices = await _repository.GetPagedAsync(page, pageSize);
      var total = await _repository.CountAsync();

      var items = offices.Select(o => new OfficeDto
      {
        Id = o.Id,
        Description = o.Description,
        RoomNumber = o.RoomNumber
      }).ToList();

      return new PagedResponse<OfficeDto>(items, total, page, pageSize, urlBuilder);
    }

    public async Task<OfficeDto> CreateAsync(OfficeCreateDto dto)
    {
      var office = new Office
      {
        Description = dto.Description,
        RoomNumber = dto.RoomNumber
      };

      await _repository.CreateAsync(office);

      var result = new OfficeDto
      {
        Description = office.Description,
        RoomNumber = office.RoomNumber
      };

      return result;
    }
  }
}
