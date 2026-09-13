public class BankAccount
{
    public int BankAccountId { get; set; }

    public string AccountNumber { get; set; }

    public string AccountType { get; set; }

    public decimal Balance { get; set; }

    public List<AccountHolderAccount> AccountHolders { get; set; }
}


public class AccountHolderAccount
{
    public int AccountHolderId { get; set; }

    public int BankAccountId { get; set; }

    public AccountHolder AccountHolder { get; set; }

    public BankAccount BankAccount { get; set; }
}


public class AccountHolder
{
    public int AccountHolderId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public List<AccountHolderAccount> BankAccounts { get; set; }
}