using EXCO_Solution.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using EXCO_Solution.Application.interfaces.Repositories;
using EXCO_Solution.Application.Interfaces.Services;
using EXCO_Solution.Application.Services;
using EXCO_Solution.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Dependency Injection
builder.Services.AddScoped<ISpendingRepository, SpendingsRepository>();
builder.Services.AddScoped<ISpendingService, SpendingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); 
app.MapControllers(); 
app.Run(); 
