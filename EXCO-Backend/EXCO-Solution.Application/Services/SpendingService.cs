using System.Linq;
using EXCO_Solution.Application.DTOs.Spending;
using EXCO_Solution.Application.interfaces.Repositories;
using EXCO_Solution.Application.Interfaces.Services;
using EXCO_Solution.Domain.Entities;

namespace EXCO_Solution.Application.Services
{
    public class SpendingService : ISpendingService
    {
        private readonly ISpendingRepository repo;

        public SpendingService(ISpendingRepository spendingRepository)
        {
            repo = spendingRepository;
        }

        public Task CreateSpendingAsync(int userId, CreateSpending dto)
        {
            if (dto.Amount <= 0)
            {
                throw new Exception(
                    "Amount must be greater than zero.");
            }

            var spending = new Spending
            {
                CategoryId = dto.CategoryId,
                AccountId = dto.AccountId,
                Amount = dto.Amount,
                Date = dto.Date,
                Description = dto.Description,
                IsPlanned = dto.IsPlanned
            };
            
            return repo.AddSpendingAsync(spending);
        }

        public async Task<List<SpendingDto>> GetByMonthAsync(int userId, int year, int month)
        {
            var spendings = await repo.GetSpendingsByMonthAsync(userId, year, month);
            if(spendings == null || !spendings.Any())
            {
                return new List<SpendingDto>();
            }

            return spendings
                .Select(spending => new SpendingDto
                {
                    Id = spending.SpendingId,
                    Amount = spending.Amount,
                    Description = spending.Description,
                    Date = spending.Date,
                    Category = spending.Category?.Name ?? string.Empty
                })
                .ToList();
        }
    }
}