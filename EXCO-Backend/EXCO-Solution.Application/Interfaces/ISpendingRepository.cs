using EXCO_Solution.Domain.Entities;

namespace EXCO_Solution.Application.interfaces;

public interface ISpendingRepository
{
    Task AddSpendingAsync(Spending spending);
    Task<List<Spending>> GetSpendingsByMonthAsync(int userId, int month, int year);
}