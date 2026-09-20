using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatCoderMANE321.Models;

public class JobTitle
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Job Title")]
    public string Title { get; set; } = string.Empty;

    [Range(0, double.MaxValue)]
    [DisplayName("Minimum Salary")]
    public decimal MinimumSalary { get; set; }

    [Range(0, double.MaxValue)]
    [DisplayName("Maximum Salary")]
    public decimal MaximumSalary { get; set; }

    [StringLength(500)]
    [DisplayName("Description")]
    public string? Description { get; set; }

    [DisplayName("Remote Eligible")]
    public bool IsRemoteEligible { get; set; }

    public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
}