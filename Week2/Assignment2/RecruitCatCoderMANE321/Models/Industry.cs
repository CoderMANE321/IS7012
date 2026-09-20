using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatCoderMANE321.Models;

public class Industry
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Industry Name")]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    [DisplayName("Description")]
    public string? Description { get; set; }

    public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();

    public ICollection<Company> Companies { get; set; } = new List<Company>();
}