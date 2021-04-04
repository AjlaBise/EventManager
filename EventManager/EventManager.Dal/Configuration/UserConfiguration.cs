using EventManager.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace EventManager.Dal.Configuration
{
    public class UserConfiguration : BaseEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder
                .HasMany(e => e.Events)
                .WithOne(u => u.CreatedByUser)
                .HasForeignKey(e => e.CreatedById);

            builder
                .HasData(new List<User> { 
                    new User { Id = 1, FirstName = "Ajla", LastName = "Bise" },
                    new User { Id = 2, FirstName = "Arman", LastName = "Bise" },
                    new User { Id = 3, FirstName = "Mahir", LastName = "Skula" }
                });
        }
    }
}