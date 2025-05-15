using Agenda.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Infrastructure.Data
{
  public class AgendaDbContext : DbContext
  {
    public AgendaDbContext(DbContextOptions<AgendaDbContext> options) : base(options) { }
    // public DbSet<User> Users { get; set; }
    public DbSet<Office> Offices { get; set; }
    // public DbSet<Calendar> Calendars { get; set; }
    // public DbSet<BusinessPartner> BusinessPartners { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(typeof(AgendaDbContext).Assembly);
      base.OnModelCreating(modelBuilder);
    }
  }
}