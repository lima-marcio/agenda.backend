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
      // Simulate fetching business partners from a database or service
      var businessPartners = new List<string> { "Partner A", "Partner B", "Partner C" };
      return Ok(businessPartners);
    }
  }
}
