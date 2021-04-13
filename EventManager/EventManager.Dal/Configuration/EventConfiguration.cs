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
                              StartDate = DateTime.Now,
                              EndDate = DateTime.Now.AddDays(6),
                              Repetition = 5,
                              TimePeriod = (Helper.TimePeriod.Daily),
                    },
                      new Event {
                              Id = 2,
                              Name = "Karaoke night",
                              Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."+
                              " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,"+
                              " when an unknown printer took a galley of type and scrambled it to make a type specimen book."+
                              "It has survived not only five centuries, but also the leap into electronic typesetting," +
                              " remaining essentially unchanged.",
                              CreatedAt = DateTime.Now,
                              CreatedById = 1,
                              ModifiedByUser = "Ajla Bise",
                              StartDate = DateTime.Now,
                              EndDate = DateTime.Now.AddMonths(3),
                              Repetition = 3,
                              TimePeriod = (Helper.TimePeriod.Weekly)
                     },
                });
        }
    }
}