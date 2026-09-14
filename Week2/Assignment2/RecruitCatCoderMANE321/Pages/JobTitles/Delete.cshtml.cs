using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatCoderMANE321.Data;
using RecruitCatCoderMANE321.Models;

namespace RecruitCatCoderMANE321.Pages.JobTitles
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatCoderMANE321.Data.RecruitCatContext _context;

        public DeleteModel(RecruitCatCoderMANE321.Data.RecruitCatContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitles.FirstOrDefaultAsync(m => m.Id == id);

            if (jobtitle is not null)
            {
                JobTitle = jobtitle;

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

            var jobtitle = await _context.JobTitles.FindAsync(id);
            if (jobtitle != null)
            {
                JobTitle = jobtitle;
                _context.JobTitles.Remove(JobTitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
