using EXCO_Solution.Domain.Entities;

namespace EXCO_Solution.Application.Interfaces;

public interface IUserRepository
{
    Task AddUserAsync(User user);
    Task<User?> GetUserByIdAsync(int id);
    Task<List<User>> GetAllUsersAsync();
    Task<bool> UserExistsAsync(string name);
}