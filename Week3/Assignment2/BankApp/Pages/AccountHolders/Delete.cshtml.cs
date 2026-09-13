using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankApp.Data;

namespace BankApp.Pages.AccountHolders
{
    public class DeleteModel : PageModel
    {
        private readonly BankApp.Data.BankContext _context;

        public DeleteModel(BankApp.Data.BankContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolders.FirstOrDefaultAsync(m => m.AccountHolderId == id);

            if (accountholder is not null)
            {
                AccountHolder = accountholder;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolders.FindAsync(id);
            if (accountholder != null)
            {
                AccountHolder = accountholder;
                _context.AccountHolders.Remove(AccountHolder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
