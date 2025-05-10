using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
  [ApiController]
  [Route("calendar")]
  public class CalendarController : ControllerBase
  {
    [HttpGet]
    public async Task<IActionResult> GetCalendars()
    {
      var businessPartners = new List<DateTime> {
        new DateTime(2023, 10, 1),
        new DateTime(2023, 10, 2),
        new DateTime(2023, 10, 3),
        new DateTime(2023, 10, 4),
        new DateTime(2023, 10, 5)
       };
      return Ok(businessPartners);
    }
  }
}
