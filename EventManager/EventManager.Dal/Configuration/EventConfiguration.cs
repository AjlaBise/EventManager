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
                    new Event {
                              Id = 1,
                              Name = "Online seminars",
                              Description = "Description of online seminar",
                              CreatedAt = DateTime.Now,
                              CreatedById = 1,
                              ModifiedByUser = "Ajla Bise",
                              StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(2),
                              StartTime = DateTime.Now.ToLocalTime(),
                              EndDate =  new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(6),
                              EndTime =DateTime.Now.ToLocalTime().AddHours(4) ,
                    },

                    new Event {
                            Id = 2,
                            Name = "Online seminars II",
                            Description = "Description of online seminar II",
                            CreatedAt = DateTime.Now,
                            CreatedById = 2 ,
                            ModifiedByUser = "Ajla Bise",
                            StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(2),
                            StartTime = DateTime.Now.ToLocalTime().AddHours(1) ,
                            EndDate =  new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(10),
                            EndTime = DateTime.Now.ToLocalTime().AddHours(2) ,
                    },

                     new Event {
                              Id = 3,
                              Name = "Online seminars",
                              Description = "Description of online seminar",
                              CreatedAt = DateTime.Now,
                              CreatedById = 1,
                              ModifiedByUser = "Ajla Bise",
                              StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                              StartTime = DateTime.Now.ToLocalTime().AddHours(4) ,
                              EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(5),
                              EndTime= DateTime.Now.ToLocalTime().AddHours(5) ,
                     },
                });
        }
    }
}