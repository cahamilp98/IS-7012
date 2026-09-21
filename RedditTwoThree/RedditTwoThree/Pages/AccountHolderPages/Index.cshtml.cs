using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RedditTwoThree.Pages.Models;

namespace RedditTwoThree.Pages.AccountHolderPages;

public class IndexModel : PageModel
{
    private readonly RedditTwoThreeContext _context;

    public IndexModel(RedditTwoThreeContext context)
    {
        _context = context;
    }

    public IList<AccountHolder> AccountHolder { get; set; } = default!;

    public async Task OnGetAsync()
    {
        AccountHolder = await _context.AccountHolder.ToListAsync();
    }
}
