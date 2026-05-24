using EXCO_Solution.Domain.Enums;

namespace EXCO_Solution.Application.DTOs.Account;

public class CreateAccount
{
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public AccountType Type { get; set; }
}