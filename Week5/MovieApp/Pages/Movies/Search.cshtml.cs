using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Pages.Movies;

public class SearchModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public SearchModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Movie> Movies { get; set; } = new List<Movie>();

    [BindProperty(SupportsGet = true)]
    public string? SearchString { get; set; }

    public async Task OnGetAsync()
    {
        if (string.IsNullOrWhiteSpace(SearchString))
        {
            Movies = new List<Movie>();
            return;
        }

        Movies = await _context.Movies
            .Where(m => m.Title.StartsWith(SearchString))
            .OrderBy(m => m.Title)
            .ToListAsync();
    }
}