namespace EXCO_Solution.Application.DTOs.Spending;

public class UpdateSpending
{
    public int SpendingId { get; set; }
    public int CategoryId { get; set; }
    public int AccountId { get; set; }

    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsPlanned { get; set; }
}