using EfDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfDAL.Configurations
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.Property(x => x.EmailAddress)
                .HasMaxLength(200);

            builder.HasOne(x => x.Person)
                .WithMany(x => x.EmailAddresses)
                .HasForeignKey(x => x.PersonId);
        }
    }
}
