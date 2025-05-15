using Agenda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.Infrastructure.Mappings
{
  public class BusinessPartnerMap : IEntityTypeConfiguration<BusinessPartner>
  {
    public void Configure(EntityTypeBuilder<BusinessPartner> builder)
    {
      builder.ToTable("BusinessPartners");

      builder.HasKey(x => x.Id);

      builder.Property(x => x.Name)
          .IsRequired()
          .HasMaxLength(100);

      builder.Property(x => x.Email)
          .IsRequired()
          .HasMaxLength(100);

      builder.Property(x => x.PartnerType)
          .IsRequired()
          .HasConversion<string>();
    }
  }
}