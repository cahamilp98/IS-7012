using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeekFiveRedoneCompletely.Models;

namespace WeekFiveRedoneCompletely.Pages.BankAccountPages;

public class DetailsModel : PageModel
{
    private readonly WeekFiveRedoneCompletelyContext _context;
    public DetailsModel(WeekFiveRedoneCompletelyContext context)
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
            BankAccount = bankaccount;
            _context.BankAccount.Remove(BankAccount);
            await _context.SaveChangesAsync();
        }
        else
        {
            BankAccount = bankaccount;
        }

        return Page();
    }
}
