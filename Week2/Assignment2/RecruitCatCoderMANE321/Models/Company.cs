using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatCoderMANE321.Models;

public class Company
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Company Name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    [DisplayName("Position Name")]
    public string PositionName { get; set; } = string.Empty;

    [Range(0, double.MaxValue)]
    [DisplayName("Minimum Salary")]
    public decimal MinimumSalary { get; set; }

    [Range(0, double.MaxValue)]
    [DisplayName("Maximum Salary")]
    public decimal MaximumSalary { get; set; }

    [DataType(DataType.Date)]
    [DisplayName("Start Date")]
    public DateTime? StartDate { get; set; }

    [Required]
    [StringLength(250)]
    [DisplayName("Location")]
    public string Location { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    [Url]
    [DisplayName("Website")]
    public string Website { get; set; } = string.Empty;

    [Range(0, int.MaxValue)]
    [DisplayName("Employee Count")]
    public int EmployeeCount { get; set; }

    [DisplayName("Offers Remote Work")]
    public bool OffersRemoteWork { get; set; }

    [DisplayName("Industry")]
    public int IndustryId { get; set; }

    public Industry? Industry { get; set; }

    public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
}