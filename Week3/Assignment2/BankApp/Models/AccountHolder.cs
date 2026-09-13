public class AccountHolder
{
    public int AccountHolderId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public List<AccountHolderAccount> BankAccounts { get; set; } = new();
}