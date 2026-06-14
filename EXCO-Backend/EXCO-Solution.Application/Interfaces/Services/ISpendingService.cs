using EXCO_Solution.Application.DTOs.Spending;

namespace EXCO_Solution.Application.Interfaces.Services;

public interface ISpendingService
{
    Task CreateSpendingAsync(int userId, CreateSpending dto);
    Task<List<SpendingDto>> GetByMonthAsync(int userId, int year, int month);
}