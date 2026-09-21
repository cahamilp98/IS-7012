using Microsoft.EntityFrameworkCore;

public class OneonOneTestContext(DbContextOptions<OneonOneTestContext> options) : DbContext(options)
{
    public DbSet<OneonOneTest.Models.AccountHolder> AccountHolder { get; set; } = default!;
}
