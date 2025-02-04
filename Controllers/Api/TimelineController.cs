using Microsoft.AspNetCore.Mvc;

namespace Ask.NET.Controllers.Api;

public class TimelineController : Controller
{
    [HttpGet]
    [Route("api/timeline")]
    [Produces("application/json")]
    public IActionResult GetTimeline()
    {
        return StatusCode(501);
    }
}