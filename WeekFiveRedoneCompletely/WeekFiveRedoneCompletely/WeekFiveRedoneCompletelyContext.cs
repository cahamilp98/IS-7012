using Microsoft.EntityFrameworkCore;

public class WeekFiveRedoneCompletelyContext(DbContextOptions<WeekFiveRedoneCompletelyContext> options) : DbContext(options)
{
    public DbSet<WeekFiveRedoneCompletely.Models.AccountHolder> AccountHolder { get; set; } = default!;
    public DbSet<WeekFiveRedoneCompletely.Models.BankAccount> BankAccount { get; set; } = default!;
}
