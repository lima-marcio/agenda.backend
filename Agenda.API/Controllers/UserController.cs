using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("user")]
  public class UserController : ControllerBase
  {
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
      await Task.CompletedTask;
      var users = new string[] { "User A", "User B", "User C" };
      return Ok(users);
    }
  }
}
