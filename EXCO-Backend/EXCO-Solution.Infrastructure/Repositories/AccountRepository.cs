using EXCO_Solution.Application.interfaces;
using EXCO_Solution.Domain.Entities;
using EXCO_Solution.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EXCO_Solution.Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly AppDbContext _context;
    public AccountRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAccountAsync(BankAccount account)
    {
        await _context.BankAccounts.AddAsync(account);
        await _context.SaveChangesAsync();
    }

    public async Task<BankAccount?> GetAccountByIdAsync(int id)
    {
        return await _context.BankAccounts.FindAsync(id).AsTask();
    }

    public async Task<List<BankAccount>> GetAllAccountsAsync(int userId)
    {
        return await _context.BankAccounts.Where(a => a.UserId == userId).ToListAsync();
    }
}