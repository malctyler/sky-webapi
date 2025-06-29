using Microsoft.EntityFrameworkCore;
using sky_webapi.Data;

public partial class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Configuration.AddUserSecrets<Program>();
        
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(connectionString)
            .Options;

        using (var context = new AppDbContext(options))
        {
            // DatabaseSeeder.UpdateCustomerPostcodes(context);
            Console.WriteLine("Successfully updated customer postcodes.");
        }
    }
}
