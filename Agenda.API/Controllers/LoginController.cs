using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("login")]
  public class LoginController : ControllerBase
  {
    [HttpGet]
    public async Task<IActionResult> GetLogin()
    {
      await Task.CompletedTask;
      var message = "Login successful!";
      return Ok(message);
    }
  }
}
