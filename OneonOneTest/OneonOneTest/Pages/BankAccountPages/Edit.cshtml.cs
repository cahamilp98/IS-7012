using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OneonOneTest.Models;

namespace OneonOneTest.Pages.BankAccountPages;

public class EditModel : PageModel
{
    private readonly OneonOneTestContext _context;

    public EditModel(OneonOneTestContext context)
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
        BankAccount = bankaccount;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(BankAccount).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BankAccountExists(BankAccount.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool BankAccountExists(int id)
    {
        return _context.BankAccount.Any(e => e.Id == id);
    }
}
