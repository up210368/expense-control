namespace EXCO_Solution.Infrastructure.Repositories;

using EXCO_Solution.Application.Interfaces.Repositories;
using EXCO_Solution.Domain.Entities;
using EXCO_Solution.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User?> GetUserByIdAsync(int id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public Task<bool> UserExistsAsync(string name)
    {
        return _context.Users.AnyAsync(u => u.Name == name);
    }
}