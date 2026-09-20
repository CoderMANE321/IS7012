using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BankApp.Data;

namespace BankApp.Pages.BankAccounts
{
    public class CreateModel : PageModel
    {
        private readonly BankApp.Data.BankContext _context;

        public CreateModel(BankApp.Data.BankContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["AccountHolderId"] = new SelectList(
                _context.AccountHolders,
                "AccountHolderId",
                "FullName"
            );

            return Page();
        }

        [BindProperty]
        public BankAccount BankAccount { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["AccountHolderId"] = new SelectList(
                    _context.AccountHolders,
                    "AccountHolderId",
                    "FullName"
                );

                return Page();
            }

            _context.BankAccounts.Add(BankAccount);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
