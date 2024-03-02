using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddSubscriptionStatusEnumEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.SubscriptionStatusEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.SubscriptionStatusEnum", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "gms.SubscriptionStatusEnum",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "SubscriptionStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 2, 8, 2, 9, 910, DateTimeKind.Utc).AddTicks(150), false, null, "Active" },
                    { 2, new DateTime(2024, 3, 2, 8, 2, 9, 910, DateTimeKind.Utc).AddTicks(159), false, null, "Suspend" },
                    { 3, new DateTime(2024, 3, 2, 8, 2, 9, 910, DateTimeKind.Utc).AddTicks(161), false, null, "Cancelled" },
                    { 4, new DateTime(2024, 3, 2, 8, 2, 9, 910, DateTimeKind.Utc).AddTicks(163), false, null, "Expired" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.SubscriptionStatusEnum");
        }
    }
}
