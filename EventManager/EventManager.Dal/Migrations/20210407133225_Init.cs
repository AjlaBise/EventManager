using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventManager.Dal.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "CreatedByUserId", "EndDate", "EndTime", "FirstName", "LastName", "ModifiedAt", "ModifiedByUser", "StartDate", "StartTime" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajla", "Bise", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "CreatedByUserId", "EndDate", "EndTime", "FirstName", "LastName", "ModifiedAt", "ModifiedByUser", "StartDate", "StartTime" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arman", "Bise", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "CreatedByUserId", "EndDate", "EndTime", "FirstName", "LastName", "ModifiedAt", "ModifiedByUser", "StartDate", "StartTime" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mahir", "Skula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Description", "EndDate", "EndTime", "ModifiedAt", "ModifiedByUser", "Name", "StartDate", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 7, 15, 32, 24, 603, DateTimeKind.Local).AddTicks(3171), 1, "Description of online seminar", new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 19, 32, 24, 607, DateTimeKind.Local).AddTicks(2590), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajla Bise", "Online seminars", new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 15, 32, 24, 607, DateTimeKind.Local).AddTicks(1819) },
                    { 3, new DateTime(2021, 4, 7, 15, 32, 24, 607, DateTimeKind.Local).AddTicks(3203), 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 20, 32, 24, 607, DateTimeKind.Local).AddTicks(3238), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajla Bise", "Online seminars", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 19, 32, 24, 607, DateTimeKind.Local).AddTicks(3221) },
                    { 4, new DateTime(2021, 4, 7, 15, 32, 24, 607, DateTimeKind.Local).AddTicks(3243), 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 20, 32, 24, 607, DateTimeKind.Local).AddTicks(3276), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajla Bise", "Karaoke night", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 19, 32, 24, 607, DateTimeKind.Local).AddTicks(3260) },
                    { 2, new DateTime(2021, 4, 7, 15, 32, 24, 607, DateTimeKind.Local).AddTicks(3076), 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.", new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 17, 32, 24, 607, DateTimeKind.Local).AddTicks(3188), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajla Bise", "Online seminars II", new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 16, 32, 24, 607, DateTimeKind.Local).AddTicks(3147) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatedById",
                table: "Events",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedByUserId",
                table: "Users",
                column: "CreatedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
