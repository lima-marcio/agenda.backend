using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("business-partner")]
  public class BusinessPartnerController : ControllerBase
  {
    [HttpGet]
    public async Task<IActionResult> GetBusinessPartners()
    {
      await Task.CompletedTask;
      var businessPartners = new List<string> { "Partner A", "Partner B", "Partner C" };
      return Ok(businessPartners);
    }
  }
}
