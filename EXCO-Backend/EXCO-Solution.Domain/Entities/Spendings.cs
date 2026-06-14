namespace EXCO_Solution.Domain.Entities;

public class Spending
{
    public int SpendingId { get; set; }
    public int? CategoryId { get; set; }
    public int AccountId { get; set; }

    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsPlanned { get; set; }

    // Navigation Properties
    public Category Category { get; set; } = null!;
    public BankAccount BankAccount { get; set; } = null!;
}