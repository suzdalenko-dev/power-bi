using bi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.IO;
using System.Text;
namespace bi.Controllers;

[ApiController]
public class HomeController: ControllerBase
{
    private readonly OracleDbContext _context;
    private readonly IWebHostEnvironment _env;
    public HomeController(OracleDbContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env     = env;
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
        var linesCounter = 0;
        /*
            1. Create the "sales" folder if it does not exists
        */
        string salesDirectory = Path.Combine(_env.ContentRootPath,"sales"); 
        if (!Directory.Exists(salesDirectory)){
            Directory.CreateDirectory(salesDirectory);
        }
        /*
            2. Define the path to the CSV file
        */
        string salesFile = Path.Combine(salesDirectory, "sales.csv");
        /*  
            3. Define the header
        */
        string header    = "Date;Market;Country;Delegate;Customer;ArticleCode;Family;Subfamily;CostPrice;SalePrice;Quantity";
        /*  
            4. Open the file for writing; "false" means it overwrites the previous content.
        */
        await using (
            var writer = new StreamWriter(salesFile, append: false, encoding: new UTF8Encoding(false))
            ){
                // 5. Write the header
                await writer.WriteLineAsync(header);
                // 6. Specify the sales period
                var startDate  = new DateTime(2020, 1, 1);
                var finishDate = DateTime.Today;
                int totalDays  = (finishDate - startDate).Days + 1;
            
                // 7. Generate 100 sales       
                for (int i = 0; i <= 11; i++){
                    linesCounter = i;
                    // Choose a random country
                    var country = CatalogData.Countries[Random.Shared.Next(CatalogData.Countries.Length)];
                    // Find your market
                    var market = CatalogData.Markets.Single( m => m.Id == country.MarketId);
                    // Find your representative
                    var salesDelegate = CatalogData.Delegates.Single(d => d.CountryId == country.Id);
                    // Get the customers assigned to the delegate
                    var delegateCustomers = CatalogData.DelegateCustomers.Where(dc => dc.DelegateId == salesDelegate.Id).ToArray();
                    // Select a random client
                    var delegateCustomer = delegateCustomers[Random.Shared.Next(delegateCustomers.Length)];
                    var customer = CatalogData.Customers.Single(c => c.Id == delegateCustomer.CustomerId);
                    // Select a random item
                    var article = CatalogData.Articles[Random.Shared.Next(CatalogData.Articles.Length)];
                    // Generate a random quantity
                    decimal quantity = Random.Shared.Next(10, 1001) / 10m;
                    // Generate a random date
                    var date = startDate.AddDays(Random.Shared.Next(totalDays));
                    // Build the sales line
                    string line =
                        $"{date:yyyy-MM-dd};" +
                        $"{market.Name};" +
                        $"{country.Name};" +
                        $"{salesDelegate.Name};" +
                        $"{customer.Name};" +
                        $"{article.Code};" +
                        $"{article.Family};" +
                        $"{article.Subfamily};" +
                        $"{article.CostPrice.ToString(CultureInfo.InvariantCulture)};" +
                        $"{article.SalePrice.ToString(CultureInfo.InvariantCulture)};" +
                        $"{quantity}";
                    // 8. Immediately record the sale in the CSV file
                    await writer.WriteLineAsync(line);
                }
            };




        // Crete 100 random sales for example
        return Ok(new
        {
            linesCounter = linesCounter 
        });
    }
}