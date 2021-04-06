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
                columns: new[] { "Id", "CreatedAt", "CreatedById", "CreatedByUserId", "EndDate", "EndTime", "FirstName", "LastName", "ModifiedAt", "StartDate", "StartTime" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajla", "Bise", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "CreatedByUserId", "EndDate", "EndTime", "FirstName", "LastName", "ModifiedAt", "StartDate", "StartTime" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arman", "Bise", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "CreatedByUserId", "EndDate", "EndTime", "FirstName", "LastName", "ModifiedAt", "StartDate", "StartTime" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mahir", "Skula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Description", "EndDate", "EndTime", "ModifiedAt", "Name", "StartDate", "StartTime" },
                values: new object[] { 1, new DateTime(2021, 4, 6, 21, 17, 3, 700, DateTimeKind.Local).AddTicks(87), 1, "Description of online seminar", new DateTime(2021, 4, 12, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(596), new DateTime(2021, 4, 6, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(981), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Online seminars", new DateTime(2021, 4, 6, 21, 17, 3, 703, DateTimeKind.Local).AddTicks(9664), new DateTime(2021, 4, 6, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Description", "EndDate", "EndTime", "ModifiedAt", "Name", "StartDate", "StartTime" },
                values: new object[] { 3, new DateTime(2021, 4, 6, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(1548), 1, "Description of online seminar", new DateTime(2021, 4, 12, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(1587), new DateTime(2021, 4, 7, 3, 17, 3, 704, DateTimeKind.Local).AddTicks(1592), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Online seminars", new DateTime(2021, 4, 8, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(1553), new DateTime(2021, 4, 7, 1, 17, 3, 704, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Description", "EndDate", "EndTime", "ModifiedAt", "Name", "StartDate", "StartTime" },
                values: new object[] { 2, new DateTime(2021, 4, 6, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(1443), 2, "Description of online seminar II", new DateTime(2021, 4, 16, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(1519), new DateTime(2021, 4, 6, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(1532), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Online seminars II", new DateTime(2021, 4, 6, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(1479), new DateTime(2021, 4, 6, 21, 17, 3, 704, DateTimeKind.Local).AddTicks(1491) });

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
