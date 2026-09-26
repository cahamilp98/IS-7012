using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OneonOneTest.Models;

namespace OneonOneTest.Pages.BankAccountPages;

public class IndexModel : PageModel
{
    private readonly OneonOneTestContext _context;

    public IndexModel(OneonOneTestContext context)
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
