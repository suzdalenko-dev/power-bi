using Microsoft.AspNetCore.Mvc;

namespace bi.Controllers;

[ApiController]
public class InterviewController: Controller
{
    [HttpGet("/interview")]
    public async Task<IActionResult> Interview()
    {
        return Ok(
            new
            {
                ok = "ok"
            }
        );
    }
}