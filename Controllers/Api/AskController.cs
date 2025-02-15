using Ask.NET.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace Ask.NET.Controllers.Api;

public class AskController : Controller
{
    private readonly IOptions<Config> config;

    [HttpPost]
    [Route("api/ask")]
    [Produces("application/json")]
    public IActionResult CreateAsk()
    {
        return StatusCode(501);
    }
}