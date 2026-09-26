using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExcerciseWeek5.Models;

namespace ExcerciseWeek5.Pages.MoviePages;

public class DeleteModel : PageModel
{
    private readonly ExcerciseWeek5Context _context;

    public DeleteModel(ExcerciseWeek5Context context)
    {
        _context = context;
    }

    [BindProperty]
    public Movie Movie { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
        if (movie is null)
        {
            return NotFound();
        }
        else
        {
            Movie = movie;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var movie = await _context.Movie.FindAsync(id);
        if (movie != null)
        {
            Movie = movie;
            _context.Movie.Remove(Movie);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
