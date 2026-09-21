using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OneonOneTest.Models;

namespace OneonOneTest.Pages.AccountHolderPages;

public class DeleteModel : PageModel
{
    private readonly OneonOneTestContext _context;

    public DeleteModel(OneonOneTestContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var accountholder = await _context.AccountHolder.FindAsync(id);
        if (accountholder != null)
        {
            AccountHolder = accountholder;
            _context.AccountHolder.Remove(AccountHolder);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
