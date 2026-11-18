using Microsoft.EntityFrameworkCore;
namespace bi.Data;

public class OracleDbContext: DbContext
{
    public OracleDbContext(DbContextOptions<OracleDbContext> opt): base(opt)
    {
        
    } 
}