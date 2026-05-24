namespace EXCO_Solution.Application.DTOs.Category;

public class UpdateCategory
{
    public int CategoryId { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
}