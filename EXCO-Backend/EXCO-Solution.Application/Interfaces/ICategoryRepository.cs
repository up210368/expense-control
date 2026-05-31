using EXCO_Solution.Domain.Entities;

namespace EXCO_Solution.Application.Interfaces;

public interface ICategoryRepository
{
    Task AddCategoryAsync(Category category);
    Task<Category?> GetCategoryByIdAsync(int id);
    Task<List<Category>> GetAllCategoriesAsync(int userId);
}