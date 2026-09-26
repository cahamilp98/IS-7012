using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OneonOneTest.Models;

namespace OneonOneTest.Pages.BankAccountPages;

public class CreateModel : PageModel
{
    private readonly OneonOneTestContext _context;

    public CreateModel(OneonOneTestContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public BankAccount BankAccount { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (BankAccount == null)
        {
            ModelState.AddModelError(string.Empty, "Invalid bank account data.");
            return Page();
        }

        // Ensure the referenced AccountHolder exists to avoid FK constraint violation
        var holderExists = await _context.AccountHolder.AnyAsync(a => a.Id == BankAccount.AccountHolderId);
        if (!holderExists)
        {
            ModelState.AddModelError(nameof(BankAccount.AccountHolderId), "Selected account holder does not exist.");
            return Page();
        }

        // Optionally load the navigation property so EF Core tracks the relationship
        var holder = await _context.AccountHolder.FindAsync(BankAccount.AccountHolderId);
        BankAccount.AccountHolder = holder;

        _context.BankAccount.Add(BankAccount);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
