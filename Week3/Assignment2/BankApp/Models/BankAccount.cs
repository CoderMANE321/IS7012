using System.ComponentModel;

public class BankAccount
{
    public int BankAccountId { get; set; }

    [DisplayName("Account Number")]
    public string AccountNumber { get; set; } = string.Empty;

    [DisplayName("Account Type")]
    public string AccountType { get; set; } = string.Empty;

    [DisplayName("Balance")]
    public decimal Balance { get; set; }

    [DisplayName("Account Holder")]
    public int AccountHolderId { get; set; }

    public AccountHolder? AccountHolder { get; set; }
}