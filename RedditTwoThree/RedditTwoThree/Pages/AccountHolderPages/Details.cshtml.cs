using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RedditTwoThree.Pages.Models;

namespace RedditTwoThree.Pages.AccountHolderPages;

public class DetailsModel : PageModel
{
    private readonly RedditTwoThreeContext _context;
    public DetailsModel(RedditTwoThreeContext context)
    {
        _context = context;
    }

    public AccountHolder AccountHolder { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? accountholderid)
    {
        if (accountholderid is null)
        {
            return NotFound();
        }

        var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.AccountHolderId == accountholderid);
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
