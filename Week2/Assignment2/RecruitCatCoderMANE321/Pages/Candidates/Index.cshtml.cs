using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatCoderMANE321.Data;
using RecruitCatCoderMANE321.Models;

namespace RecruitCatCoderMANE321.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatCoderMANE321.Data.RecruitCatContext _context;

        public IndexModel(RecruitCatCoderMANE321.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidates
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
