using EXCO_Solution.Application.interfaces;
using EXCO_Solution.Domain.Entities;
using EXCO_Solution.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EXCO_Solution.Infrastructure.Repositories;

public class SpendingsRepository : ISpendingRepository
{
    private readonly AppDbContext _context;

    public SpendingsRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddSpendingAsync(Spending spending)
    {
        await _context.Spendings.AddAsync(spending);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Spending>> GetSpendingsByMonthAsync(
    int userId,
    int year,
    int month)
    {
        var startDate = new DateTime(year, month, 1);

        var endDate = startDate.AddMonths(1);

        return await _context.Spendings
            .Include(x => x.Category)
            .Include(x => x.BankAccount)
            .Where(x =>
                x.BankAccount.UserId == userId &&
                x.Date >= startDate &&
                x.Date < endDate)
            .OrderByDescending(x => x.Date)
            .ToListAsync();
    }
}