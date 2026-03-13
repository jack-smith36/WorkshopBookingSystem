using Microsoft.EntityFrameworkCore;
using WorkshopBookingSystem.Domain.Entities;

namespace WorkshopBookingSystem.Infrastructure.Persistence;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users => Set<User>();
}
