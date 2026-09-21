using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RedditTwoThree.Pages.Models;

namespace RedditTwoThree.Pages.AccountHolderPages;

public class DeleteModel : PageModel
{
    private readonly RedditTwoThreeContext _context;

    public DeleteModel(RedditTwoThreeContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? accountholderid)
    {
        if (accountholderid is null)
        {
            return NotFound();
        }

        var accountholder = await _context.AccountHolder.FindAsync(accountholderid);
        if (accountholder != null)
        {
            AccountHolder = accountholder;
            _context.AccountHolder.Remove(AccountHolder);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
