using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OneonOneTest.Models;

namespace OneonOneTest.Pages.AccountHolderPages;

public class IndexModel : PageModel
{
    private readonly OneonOneTestContext _context;

    public IndexModel(OneonOneTestContext context)
    {
        _context = context;
    }

    public IList<AccountHolder> AccountHolder { get; set; } = default!;

    public async Task OnGetAsync()
    {
        AccountHolder = await _context.AccountHolder.ToListAsync();
    }
}
