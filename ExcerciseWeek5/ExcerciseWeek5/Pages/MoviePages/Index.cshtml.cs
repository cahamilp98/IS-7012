using ExcerciseWeek5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ExcerciseWeek5.Pages.MoviePages;

public class IndexModel : PageModel
{
    private readonly ExcerciseWeek5Context _context;

    public IndexModel(ExcerciseWeek5Context context)
    {
        _context = context;
    }

    public IList<Movie> Movie { get; set; } = default!;

    [BindProperty(SupportsGet = true)]
    public string? SearchString { get; set; }

    public SelectList? Genres { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? MovieGenre { get; set; }
    public async Task OnGetAsync()
    {
        var movies = from m in _context.Movie
                     select m;
        if (!string.IsNullOrEmpty(SearchString))
        {
            movies = movies.Where(s => s.Title.Contains(SearchString));
        }

        Movie = await movies.ToListAsync();
    }
}