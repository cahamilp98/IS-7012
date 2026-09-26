using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit.Pages.BankAccountPages;

public class IndexModel : PageModel
{
    private readonly RedditContext _context;

    public IndexModel(RedditContext context)
    {
        _context = context;
    }

    public IList<BankAccount> BankAccount { get; set; } = default!;

    public async Task OnGetAsync()
    {
        BankAccount = await _context.BankAccount.ToListAsync();
    }
}
