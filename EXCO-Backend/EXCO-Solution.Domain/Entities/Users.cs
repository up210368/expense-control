namespace EXCO_Solution.Domain.Entities;
public class User
{
    public int UserId { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

    // Navigation Properties
    public ICollection<Category> Categories { get; private set; } = new List<Category>();
    public ICollection<BankAccount> BankAccounts { get; private set; } = new List<BankAccount>();

    private User() { }

    public User(string name, string passwordHash)
    {
        Name = name;
        PasswordHash = passwordHash;
        CreatedAt = DateTime.UtcNow;
    }
}