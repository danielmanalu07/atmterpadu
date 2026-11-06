
using Microsoft.AspNetCore.Mvc;

namespace RinelReactApp.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
public class StatusController : ControllerBase
{
    /// <summary>
    /// CONTOH DOKUMENTASI API CONTROLLER
    /// </summary>
    /// <remarks>
    /// Hanya untuk return JSON saja
    /// </remarks>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            application = "RinelReactApp",
            framework = "ASP.NET Core MVC",
            frontend = "React SPA",
            status = "Running"
        });
    }
}
