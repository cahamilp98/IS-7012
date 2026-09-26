using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExcerciseWeek5.Models;

namespace ExcerciseWeek5.Pages.MoviePages;

public class IndexModel : PageModel
{
    private readonly ExcerciseWeek5Context _context;

    public IndexModel(ExcerciseWeek5Context context)
    {
        _context = context;
    }

    public IList<Movie> Movie { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Movie = await _context.Movie.ToListAsync();
    }
}
