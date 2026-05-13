using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities;

public class BankAccount
{
    public int AccountId { get; private set; }
    public int UserId { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public decimal Balance { get; private set; }
    public AccountType Type { get; private set; }

    // Navigation Properties
    public User User { get; private set; } = null!;
    public ICollection<Spending> Spendings { get; private set; } = new List<Spending>();

    private BankAccount() { }

    public BankAccount(int userId, string name, decimal balance, AccountType type)
    {
        UserId = userId;
        Name = name;
        Balance = balance;
        Type = type;
    }
}