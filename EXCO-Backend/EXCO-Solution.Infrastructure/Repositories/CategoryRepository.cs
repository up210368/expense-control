namespace EXCO_Solution.Infrastructure.Repositories;
using EXCO_Solution.Application.Interfaces.Repositories;
using EXCO_Solution.Domain.Entities;
using EXCO_Solution.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;
    public CategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task AddCategoryAsync(Category category)
    {
        _context.Categories.Add(category);
        return _context.SaveChangesAsync();
    }

    public Task<List<Category>> GetAllCategoriesAsync(int userId)
    {
        return _context.Categories.Where(c => c.UserId == userId).ToListAsync();
    }

    public Task<Category?> GetCategoryByIdAsync(int id)
    {
        return _context.Categories.FindAsync(id).AsTask();
    }
}