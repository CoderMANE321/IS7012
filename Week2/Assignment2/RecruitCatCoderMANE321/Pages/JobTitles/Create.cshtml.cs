using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatCoderMANE321.Data;
using RecruitCatCoderMANE321.Models;

namespace RecruitCatCoderMANE321.Pages.JobTitles
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatCoderMANE321.Data.RecruitCatContext _context;

        public CreateModel(RecruitCatCoderMANE321.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JobTitles.Add(JobTitle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
