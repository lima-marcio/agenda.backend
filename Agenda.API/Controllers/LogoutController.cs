using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("logout")]
  public class LogoutController : ControllerBase
  {
    [HttpGet]
    public async Task<IActionResult> GetLogout()
    {
      await Task.CompletedTask;
      var message = "Logout successful";
      return Ok(message);
    }
  }
}
