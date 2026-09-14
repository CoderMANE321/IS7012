namespace RecruitCatCoderMANE321.Models;

public class Industry
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();

    public ICollection<Company> Companies { get; set; } = new List<Company>();
}