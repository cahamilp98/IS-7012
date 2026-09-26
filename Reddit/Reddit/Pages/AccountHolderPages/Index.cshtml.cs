using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit.Pages.AccountHolderPages;

public class IndexModel : PageModel
{
    private readonly RedditContext _context;

    public IndexModel(RedditContext context)
    {
        _context = context;
    }

    public IList<AccountHolder> AccountHolder { get; set; } = default!;

    public async Task OnGetAsync()
    {
        AccountHolder = await _context.AccountHolder.ToListAsync();
    }
}
