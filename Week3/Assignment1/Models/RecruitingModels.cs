public class Candidate
{
    public int CandidateId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public int JobTitleId { get; set; }

    public JobTitle JobTitle { get; set; }
}


public class Company
{
    public int CompanyId { get; set; }

    public string Name { get; set; }

    public string Location { get; set; }

    public int IndustryId { get; set; }

    public Industry Industry { get; set; }

    public List<JobTitle> JobTitles { get; set; }
}


public class JobTitle
{
    public int JobTitleId { get; set; }

    public string JobTitleName { get; set; }

    public int CompanyId { get; set; }

    public Company Company { get; set; }

    public List<Candidate> Candidates { get; set; }
}


public class Industry
{
    public int IndustryId { get; set; }

    public string Name { get; set; }

    public List<Company> Companies { get; set; }
}