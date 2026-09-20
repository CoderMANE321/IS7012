using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatCoderMANE321.Data;
using RecruitCatCoderMANE321.Models;

namespace RecruitCatCoderMANE321.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatCoderMANE321.Data.RecruitCatContext _context;

        public DetailsModel(RecruitCatCoderMANE321.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.Industry)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (company is not null)
            {
                Company = company;

                return Page();
            }

            return NotFound();
        }
    }
}
