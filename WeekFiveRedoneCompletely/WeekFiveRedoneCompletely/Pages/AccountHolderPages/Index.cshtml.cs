using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeekFiveRedoneCompletely.Models;

namespace WeekFiveRedoneCompletely.Pages.AccountHolderPages;

public class IndexModel : PageModel
{
    private readonly WeekFiveRedoneCompletelyContext _context;

    public IndexModel(WeekFiveRedoneCompletelyContext context)
    {
        _context = context;
    }

    public IList<AccountHolder> AccountHolder { get; set; } = default!;

    public async Task OnGetAsync()
    {
        AccountHolder = await _context.AccountHolder.ToListAsync();
    }
}
