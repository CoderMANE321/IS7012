using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankApp.Data;

namespace BankApp.Pages.BankAccounts
{
    public class DetailsModel : PageModel
    {
        private readonly BankApp.Data.BankContext _context;

        public DetailsModel(BankApp.Data.BankContext context)
        {
            _context = context;
        }

        public BankAccount BankAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccounts.FirstOrDefaultAsync(m => m.BankAccountId == id);

            if (bankaccount is not null)
            {
                BankAccount = bankaccount;

                return Page();
            }

            return NotFound();
        }
    }
}
