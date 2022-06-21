using Microsoft.AspNetCore.Mvc;

namespace SwaggerUiBugDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    /// <summary>
    /// This method returns a file containing a single "ß" character in latin-1 encoding
    /// </summary>
    [HttpGet]
    public IActionResult Get() => File(new byte[] {223}, "text/plain", "file.txt");
}