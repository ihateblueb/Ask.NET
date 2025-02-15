using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Ask.NET.Controllers.Api;

public class LoginController : Controller
{
    [HttpPost]
    [Route("api/login")]
    [Produces("application/json")]
    public IActionResult Login()
    {
        return StatusCode(501);
    }
}