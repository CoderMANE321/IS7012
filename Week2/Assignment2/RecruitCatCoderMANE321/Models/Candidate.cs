namespace RecruitCatCoderMANE321.Models;

public class Candidate
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public decimal TargetSalary { get; set; }

    public DateTime? StartDate { get; set; }

    public string Email { get; set; } = string.Empty;

    public int YearsOfExperience { get; set; }

    public bool IsAvailable { get; set; }

    public int? CompanyId { get; set; }

    public Company? Company { get; set; }

    public int JobTitleId { get; set; }

    public JobTitle JobTitle { get; set; } = null!;

    public int IndustryId { get; set; }

    public Industry Industry { get; set; } = null!;
}