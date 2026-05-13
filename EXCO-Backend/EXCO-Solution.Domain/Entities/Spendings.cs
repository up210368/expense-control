namespace ExpenseTracker.Domain.Entities;

public class Spending
{
    public int SpendingId { get; private set; }
    public int CategoryId { get; private set; }
    public int AccountId { get; private set; }

    public decimal Amount { get; private set; }
    public DateTime Date { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public bool IsPlanned { get; private set; }

    // Navigation Properties
    public Category Category { get; private set; } = null!;
    public BankAccount BankAccount { get; private set; } = null!;

    private Spending() { }

    public Spending(
        int categoryId,
        int accountId,
        decimal amount,
        DateTime date,
        string description,
        bool isPlanned)
    {
        if (amount <= 0)
            throw new ArgumentException("The amount must be greater than zero.");

        CategoryId = categoryId;
        AccountId = accountId;
        Amount = amount;
        Date = date;
        Description = description;
        IsPlanned = isPlanned;
    }
}