using bi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bi.Controllers;

[ApiController]
public class HomeController: ControllerBase
{
    private readonly OracleDbContext _context;
    public HomeController(OracleDbContext context)
    {
        _context = context;
    }

    [HttpGet("/")]
    public async Task<IActionResult> Index()
    {
        var conn = _context.Database.GetDbConnection();
        await conn.OpenAsync();
        await using var command = conn.CreateCommand();
        command.CommandText = """
            SELECT TABLE_NAME
            FROM USER_TABLES
            ORDER BY TABLE_NAME
        """;
        var result = await command.ExecuteScalarAsync();
        await conn.CloseAsync();
        return Ok(new {
                    application = "Power BI API",
                    result = result,
                });
    }
}