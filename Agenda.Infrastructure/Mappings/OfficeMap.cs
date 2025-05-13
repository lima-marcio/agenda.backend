using Agenda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.Infrastructure.Mappings
{
  public class OfficeMap : IEntityTypeConfiguration<Office>
  {
    public void Configure(EntityTypeBuilder<Office> builder)
    {
      builder.ToTable("Offices");

      builder.HasKey(x => x.Id);

      builder.Property(x => x.Description)
          .IsRequired()
          .HasMaxLength(100);

      builder.Property(x => x.RoomNumber)
          .IsRequired()
          .HasMaxLength(10);
    }
  }
}