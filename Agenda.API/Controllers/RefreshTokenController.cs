using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("refresh-token")]
  public class RefreshTokenController : ControllerBase
  {
    [HttpGet]
    public async Task<IActionResult> GetRefreshToken()
    {
      await Task.CompletedTask;
      var refreshToken = "165a1651h66516165f16a5g13161@351$6516adfa6uyiaqe_k";
      return Ok(refreshToken);
    }
  }
}
