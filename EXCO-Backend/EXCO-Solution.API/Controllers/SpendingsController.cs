using EXCO_Solution.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using EXCO_Solution.Application.DTOs.Spending;

namespace EXCO_Solution.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpendingsController : ControllerBase
    {
        private readonly ISpendingService spendingService;

        public SpendingsController(ISpendingService spendingService)
        {
            this.spendingService = spendingService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpending(CreateSpending dto)
        {
            try
            {
                int userId = 1; // Placeholder for user ID, replace with actual user context
                await spendingService.CreateSpendingAsync(userId, dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{year}/{month}")]
        public async Task<IActionResult> GetSpendingsByMonth(int year, int month)
        {
            int userId = 1; // Placeholder for user ID, replace with actual user context
            var spendings = await spendingService.GetByMonthAsync(userId, year, month);
            return Ok(spendings);
        }
    }
}