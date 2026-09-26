using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit.Pages.BankAccountPages;

public class DetailsModel : PageModel
{
    private readonly RedditContext _context;
    public DetailsModel(RedditContext context)
    {
        _context = context;
    }

    public BankAccount BankAccount { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var bankaccount = await _context.BankAccount.FirstOrDefaultAsync(m => m.Id == id);
        if (bankaccount is null)
        {
            return NotFound();
        }
        else
        {
            BankAccount = bankaccount;
        }

        return Page();
    }
}
