using EXCO_Solution.Domain.Entities;

namespace EXCO_Solution.Application.interfaces;

public interface IAccountRepository
{
    Task AddAccountAsync(BankAccount account);
    Task<BankAccount?> GetAccountByIdAsync(int id);
    Task<List<BankAccount>> GetAllAccountsAsync(int userId);
}