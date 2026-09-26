using Microsoft.EntityFrameworkCore;

public class RedditContext(DbContextOptions<RedditContext> options) : DbContext(options)
{
    public DbSet<Reddit.Models.AccountHolder> AccountHolder { get; set; } = default!;
}
