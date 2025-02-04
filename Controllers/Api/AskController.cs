using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Ask.NET.Controllers.Api;

public class AskController : Controller
{
    [HttpPost]
    [Route("api/ask")]
    [Produces("application/json")]
    public IActionResult CreateAsk()
    {
        return StatusCode(501);
    }
}