using EXCO_Solution.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EXCO_Solution.Infrastructure.Persistence;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<BankAccount> BankAccounts => Set<BankAccount>();
    public DbSet<Spending> Spendings => Set<Spending>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // USER
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.UserId);

            entity.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(u => u.PasswordHash)
                .IsRequired(); 

            entity.Property(u => u.CreatedAt)
                .IsRequired(); 
        });

        // CATEGORY
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(c => c.CategoryId);

            entity.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(c => c.User)
                .WithMany(u => u.Categories)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // BANK ACCOUNT
        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasKey(a => a.AccountId);

            entity.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(a => a.Balance)
                .HasColumnType("decimal(18,2)");

            entity.Property(a => a.Type)
                .IsRequired(); 

            entity.HasOne(a => a.User)
                .WithMany(u => u.BankAccounts)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // SPENDING
        modelBuilder.Entity<Spending>(entity =>
        {
            entity.HasKey(s => s.SpendingId);

            entity.Property(s => s.Amount)
                .HasColumnType("decimal(18,2)");

            entity.Property(s => s.Description)
                .HasMaxLength(250);
                
            entity.Property(s => s.Date)
                .IsRequired(); 

            entity.Property(s => s.IsPlanned)
                .IsRequired(); 

            entity.HasOne(s => s.Category)
                .WithMany(c => c.Spendings)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.BankAccount)
                .WithMany(a => a.Spendings)
                .HasForeignKey(s => s.AccountId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}