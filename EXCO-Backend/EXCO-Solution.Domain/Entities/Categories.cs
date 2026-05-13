namespace EXCO_Solution.Domain.Entities;

public class Category
{
    public int CategoryId { get; private set; }
    public int UserId { get; private set; }
    public string Name { get; private set; } = string.Empty;

    // Navigation Properties
    public User User { get; private set; } = null!;
    public ICollection<Spending> Spendings { get; private set; } = new List<Spending>();

    private Category() { }

    public Category(int userId, string name)
    {
        UserId = userId;
        Name = name;
    }
}