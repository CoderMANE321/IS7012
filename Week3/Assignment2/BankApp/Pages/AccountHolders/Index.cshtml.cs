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
    public class IndexModel : PageModel
    {
        private readonly BankApp.Data.BankContext _context;

        public IndexModel(BankApp.Data.BankContext context)
        {
            _context = context;
        }

        public IList<AccountHolder> AccountHolder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            AccountHolder = await _context.AccountHolders.ToListAsync();
        }
    }
}
