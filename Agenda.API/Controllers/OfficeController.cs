using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using Agenda.Application.UseCases.Office;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("office")]
  public class OfficeController : ControllerBase
  {
    private readonly IOfficeService _service;
    private readonly CreateOfficeUseCase _createUseCase;

    public OfficeController(
      IOfficeService service,
      CreateOfficeUseCase createUseCase)
    {
      _service = service;
      _createUseCase = createUseCase;
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
      var result = await _createUseCase.ExecuteAsync(dto);
      return CreatedAtAction(nameof(GetById), new { id = result..Id }, result);
      // if (!ModelState.IsValid)
      //   return BadRequest(ModelState);

      // var created = await _service.CreateAsync(dto);
      // return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
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
