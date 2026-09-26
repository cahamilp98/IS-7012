using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeekFiveRedoneCompletely.Models;

namespace WeekFiveRedoneCompletely.Pages.BankAccountPages;

public class IndexModel : PageModel
{
    private readonly WeekFiveRedoneCompletelyContext _context;

    public IndexModel(WeekFiveRedoneCompletelyContext context)
    {
        _context = context;
    }

    public IList<BankAccount> BankAccount { get; set; } = default!;

    public async Task OnGetAsync()
    {
        BankAccount = await _context.BankAccount
              .Include(b => b.AccountHolder).ToListAsync();
    }
}
