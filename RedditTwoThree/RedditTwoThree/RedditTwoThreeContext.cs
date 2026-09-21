using Microsoft.EntityFrameworkCore;

public class RedditTwoThreeContext(DbContextOptions<RedditTwoThreeContext> options) : DbContext(options)
{
    public DbSet<RedditTwoThree.Pages.Models.AccountHolder> AccountHolder { get; set; } = default!;
}
