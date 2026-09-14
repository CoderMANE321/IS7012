namespace RecruitCatCoderMANE321.Models;

public class JobTitle
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public decimal MinimumSalary { get; set; }

    public decimal MaximumSalary { get; set; }

    public string? Description { get; set; }

    public bool IsRemoteEligible { get; set; }

    public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
}