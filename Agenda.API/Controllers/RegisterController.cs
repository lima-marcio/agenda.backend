using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("register")]
  public class RegisterController : ControllerBase
  {
    [HttpGet]
    public async Task<IActionResult> GetRegister()
    {
      await Task.CompletedTask;
      var message = "Register successful!";
      return Ok(message);
    }
  }
}
