using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit.Pages.AccountHolderPages;

public class CreateModel : PageModel
{
    private readonly RedditContext _context;

    public CreateModel(RedditContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public AccountHolder AccountHolder { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.AccountHolder.Add(AccountHolder);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
