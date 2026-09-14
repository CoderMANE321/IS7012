using Microsoft.EntityFrameworkCore;
using RecruitCatCoderMANE321.Models;

namespace RecruitCatCoderMANE321.Data;

public class RecruitCatContext : DbContext
{
    public RecruitCatContext(DbContextOptions<RecruitCatContext> options)
        : base(options)
    {
    }

    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Industry> Industries { get; set; }
    public DbSet<JobTitle> JobTitles { get; set; }
}