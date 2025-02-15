using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Ask.NET.Controllers.Api;

public class RegisterController : Controller
{
    [HttpPost]
    [Route("api/register")]
    [Produces("application/json")]
    public IActionResult Register()
    {
        return StatusCode(501);
    }
}