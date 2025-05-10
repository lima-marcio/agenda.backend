using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("office")]
  public class OfficeController : ControllerBase
  {
    [HttpGet]
    public async Task<IActionResult> GetOffices()
    {
      var oficces = new List<string> { "New York", "Tokyo", "Seul" };
      return Ok(oficces);
    }
  }
}
