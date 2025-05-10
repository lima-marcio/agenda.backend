using Agenda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.Infrastructure.Mappings
{
  public class UserMap : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.ToTable("Users");

      builder.HasKey(x => x.Id);

      builder.Property(x => x.UserName)
          .IsRequired()
          .HasMaxLength(50);

      builder.Property(x => x.Email)
          .IsRequired()
          .HasMaxLength(100);

      builder.Property(x => x.Rule)
          .IsRequired()
          .HasMaxLength(20);
    }
  }
}