public class BankAccount
{
    public int BankAccountId { get; set; }

    public string AccountNumber { get; set; } = string.Empty;

    public string AccountType { get; set; } = string.Empty;

    public decimal Balance { get; set; }

    public List<AccountHolderAccount> AccountHolders { get; set; } = new();
}