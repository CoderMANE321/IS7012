using System.ComponentModel;
public class AccountHolder
{
    public int AccountHolderId { get; set; }

    [DisplayName("First Name")]
    public string FirstName { get; set; } = string.Empty;

    [DisplayName("Last Name")]
    public string LastName { get; set; } = string.Empty;

    public string FullName
    {
        get { return $"{FirstName} {LastName}"; }
    }

    [DisplayName("Email")]
    public string Email { get; set; } = string.Empty;

    public List<AccountHolderAccount> BankAccounts { get; set; } = new();
}