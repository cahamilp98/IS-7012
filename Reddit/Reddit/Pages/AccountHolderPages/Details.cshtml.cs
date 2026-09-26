using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit.Pages.AccountHolderPages;

public class DetailsModel : PageModel
{
    private readonly RedditContext _context;
    public DetailsModel(RedditContext context)
    {
        _context = context;
    }

    public AccountHolder AccountHolder { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.Id == id);
        if (accountholder is null)
        {
            return NotFound();
        }
        else
        {
            AccountHolder = accountholder;
        }

        return Page();
    }
}
