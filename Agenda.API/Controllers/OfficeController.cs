using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using Agenda.Application.Interfaces.UseCases.Office;
using Agenda.Application.UseCases.Office;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("office")]
  public class OfficeController : ControllerBase
  {
    private readonly IOfficeService _service;
    private readonly ICreateOfficeUseCase _createUseCase;
    private readonly IUpdateOfficeUseCase _updateUseCase;

    public OfficeController(
      IOfficeService service,
      ICreateOfficeUseCase createUseCase,
      IUpdateOfficeUseCase updateUseCase)
    {
      _service = service;
      _createUseCase = createUseCase;
      _updateUseCase = updateUseCase;
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
    public async Task<IActionResult> Create(OfficeCreateDto dto)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);
      var result = await _createUseCase.ExecuteAsync(dto);
      return CreatedAtAction(nameof(GetById), new { id = result }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, OfficeUpdateDto dto)
    {
      if (id != dto.Id) return BadRequest();
      var result = await _updateUseCase.ExecuteAsync(dto);

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
