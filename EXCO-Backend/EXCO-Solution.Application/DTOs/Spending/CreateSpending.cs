namespace EXCO_Solution.Application.DTOs.Spending;

public class CreateSpending
{
    public int? CategoryId { get; set; } = null;
    public int AccountId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsPlanned { get; set; }
}