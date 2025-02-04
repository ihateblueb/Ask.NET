using Ask.NET.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Ask.NET.Controllers.Api;

public class UserController : Controller
{
    [HttpGet]
    [Route("api/user")]
    [Produces("application/json")]
    public IActionResult GetUser()
    {
        return StatusCode(501);
    }
}