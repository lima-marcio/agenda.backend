using Agenda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.Infrastructure.Mappings
{
  public class CalendarMap : IEntityTypeConfiguration<Calendar>
  {
    public void Configure(EntityTypeBuilder<Calendar> builder)
    {
      builder.ToTable("Calendars");

      builder.HasKey(x => x.Id);

      builder.Property(x => x.UserId)
          .IsRequired();

      builder.Property(x => x.BusinessPartnerId)
          .IsRequired();

      builder.Property(x => x.OfficeId)
          .IsRequired();

      builder.Property(x => x.ReservationDateTime)
          .IsRequired()
          .HasColumnType("datetime");

      builder.Property(x => x.Description)
          .IsRequired()
          .HasMaxLength(500);

      builder.Property(x => x.Status)
          .IsRequired()
          .HasMaxLength(20);
    }
  }
}