using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeekFiveRedoneCompletely.Models;

namespace WeekFiveRedoneCompletely.Pages.AccountHolderPages;

public class DetailsModel : PageModel
{
    private readonly WeekFiveRedoneCompletelyContext _context;
    public DetailsModel(WeekFiveRedoneCompletelyContext context)
    {
        _context = context;
    }

    public AccountHolder AccountHolder { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.Id == id);
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
}
