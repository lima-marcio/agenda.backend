using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("office")]
  public class OfficeController : ControllerBase
  {
    private readonly IOfficeService _service;

    public OfficeController(IOfficeService service)
    {
      _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var result = await _service.GetAllAsync();
      return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var office = await _service.GetByIdAsync(id);
      if (office == null) return NotFound();
      return Ok(office);
    }

    [HttpPost]
    public async Task<IActionResult> Create(OfficeDto dto)
    {
      var created = await _service.CreateAsync(dto);
      return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, OfficeDto dto)
    {
      if (id != dto.Id) return BadRequest();
      var updated = await _service.UpdateAsync(dto);
      if (!updated) return NotFound();
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      var deleted = await _service.DeleteAsync(id);
      if (!deleted) return NotFound();
      return NoContent();
    }
  }
}
