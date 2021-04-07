﻿// <auto-generated />
using System;
using EventManager.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventManager.Dal.Migrations
{
    [DbContext(typeof(EventManagerDbContext))]
    partial class EventManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventManager.Dal.Domain.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 4, 7, 15, 32, 24, 603, DateTimeKind.Local).AddTicks(3171),
                            CreatedById = 1,
                            Description = "Description of online seminar",
                            EndDate = new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(2021, 4, 7, 19, 32, 24, 607, DateTimeKind.Local).AddTicks(2590),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedByUser = "Ajla Bise",
                            Name = "Online seminars",
                            StartDate = new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2021, 4, 7, 15, 32, 24, 607, DateTimeKind.Local).AddTicks(1819)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 4, 7, 15, 32, 24, 607, DateTimeKind.Local).AddTicks(3076),
                            CreatedById = 2,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",
                            EndDate = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(2021, 4, 7, 17, 32, 24, 607, DateTimeKind.Local).AddTicks(3188),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedByUser = "Ajla Bise",
                            Name = "Online seminars II",
                            StartDate = new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2021, 4, 7, 16, 32, 24, 607, DateTimeKind.Local).AddTicks(3147)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 4, 7, 15, 32, 24, 607, DateTimeKind.Local).AddTicks(3203),
                            CreatedById = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",
                            EndDate = new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(2021, 4, 7, 20, 32, 24, 607, DateTimeKind.Local).AddTicks(3238),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedByUser = "Ajla Bise",
                            Name = "Online seminars",
                            StartDate = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2021, 4, 7, 19, 32, 24, 607, DateTimeKind.Local).AddTicks(3221)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2021, 4, 7, 15, 32, 24, 607, DateTimeKind.Local).AddTicks(3243),
                            CreatedById = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",
                            EndDate = new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(2021, 4, 7, 20, 32, 24, 607, DateTimeKind.Local).AddTicks(3276),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedByUser = "Ajla Bise",
                            Name = "Karaoke night",
                            StartDate = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2021, 4, 7, 19, 32, 24, 607, DateTimeKind.Local).AddTicks(3260)
                        });
                });

            modelBuilder.Entity("EventManager.Dal.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedById = 0,
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ajla",
                            LastName = "Bise",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedById = 0,
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Arman",
                            LastName = "Bise",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedById = 0,
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mahir",
                            LastName = "Skula",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EventManager.Dal.Domain.Event", b =>
                {
                    b.HasOne("EventManager.Dal.Domain.User", "CreatedByUser")
                        .WithMany("Events")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");
                });

            modelBuilder.Entity("EventManager.Dal.Domain.User", b =>
                {
                    b.HasOne("EventManager.Dal.Domain.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.Navigation("CreatedByUser");
                });

            modelBuilder.Entity("EventManager.Dal.Domain.User", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
