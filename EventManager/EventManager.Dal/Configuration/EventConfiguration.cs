using EventManager.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EventManager.Dal.Configuration
{
    public class EventConfiguration : BaseEntityTypeConfiguration<Event>
    {
        public override void Configure(EntityTypeBuilder<Event> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.Name)
                .IsRequired();

            builder
                .HasOne(user => user.CreatedByUser)
                .WithMany(e => e.Events)
                .HasForeignKey(p => p.CreatedById);

            builder
                .HasData(new List<Event> { 
                    new Event { Id = 1, Name = "Online seminars", Description = "Description of online seminar", CreatedAt = DateTime.Now, CreatedById = 1 },
                    new Event { Id = 2, Name = "Online seminars II", Description = "Description of online seminar II", CreatedAt = DateTime.Now, CreatedById = 1 },
                });
        }
    }
}