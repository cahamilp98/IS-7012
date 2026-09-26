using Microsoft.EntityFrameworkCore;

namespace ExcerciseWeek5
{
    public class ExcerciseWeek5Context : DbContext
    {
        public ExcerciseWeek5Context(DbContextOptions<ExcerciseWeek5Context> options)
            : base(options)
        {
        }

        public DbSet<Models.Movie> Movie { get; set; } = default!;
    }
}
