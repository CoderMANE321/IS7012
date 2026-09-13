public class AccountHolderAccount
{
    public int AccountHolderId { get; set; }

    public int BankAccountId { get; set; }

    public AccountHolder? AccountHolder { get; set; }

    public BankAccount? BankAccount { get; set; }
}