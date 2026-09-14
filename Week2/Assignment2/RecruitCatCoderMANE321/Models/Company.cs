namespace RecruitCatCoderMANE321.Models;

public class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string PositionName { get; set; } = string.Empty;

    public decimal MinimumSalary { get; set; }

    public decimal MaximumSalary { get; set; }

    public DateTime? StartDate { get; set; }

    public string Location { get; set; } = string.Empty;

    public string Website { get; set; } = string.Empty;

    public int EmployeeCount { get; set; }

    public bool OffersRemoteWork { get; set; }

    public int IndustryId { get; set; }

    public Industry Industry { get; set; } = null!;

    public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
}