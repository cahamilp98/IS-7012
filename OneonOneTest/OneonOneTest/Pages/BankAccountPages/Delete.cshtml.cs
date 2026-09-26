using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OneonOneTest.Models;

namespace OneonOneTest.Pages.BankAccountPages;

public class DeleteModel : PageModel
{
    private readonly OneonOneTestContext _context;

    public DeleteModel(OneonOneTestContext context)
    {
        _context = context;
    }

    [BindProperty]
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
            return NotFound();
        }
        else
        {
            BankAccount = bankaccount;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var bankaccount = await _context.BankAccount.FindAsync(id);
        if (bankaccount != null)
        {
            BankAccount = bankaccount;
            _context.BankAccount.Remove(BankAccount);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
