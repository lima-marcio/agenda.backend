using Schedule.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Configuration> Configurations { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
  }
}
