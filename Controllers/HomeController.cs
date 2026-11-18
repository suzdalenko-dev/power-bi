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
        var result = new List<string>();
        await using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync()){
            result.Add(reader.GetString(0));
        }
        await conn.CloseAsync();
        return Ok(new {
                    application = "Power BI API",
                    result = result,
                });
    }



    [HttpGet("/populate-db")]
    public async Task<IActionResult> PopulateDatabase()
    {

        // Crete 100 random sales for example
        return Ok(new
        {
            populateDb = false 
        });
    }
}