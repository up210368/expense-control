using EXCO_Solution.Domain.Entities;

namespace EXCO_Solution.Application.Interfaces.Repositories;

public interface ICategoryRepository
{
    Task AddCategoryAsync(Category category);
    Task<Category?> GetCategoryByIdAsync(int id);
    Task<List<Category>> GetAllCategoriesAsync(int userId);
}