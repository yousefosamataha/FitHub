using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class addCategoryEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.category", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "gms.category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("04ec7783-f082-4ee1-9d85-e8bd0d65a9da"), new DateTime(2024, 1, 26, 22, 5, 44, 154, DateTimeKind.Local).AddTicks(7153), false, null, "Total Gym Exercises for Legs" },
                    { new Guid("10c0d450-fa01-451f-8a1f-ce8f9155f4c4"), new DateTime(2024, 1, 26, 22, 5, 44, 154, DateTimeKind.Local).AddTicks(7080), false, null, "Regular" },
                    { new Guid("11c076f9-ff15-4902-87b1-18d67328cf03"), new DateTime(2024, 1, 26, 22, 5, 44, 154, DateTimeKind.Local).AddTicks(7146), false, null, "Limited" },
                    { new Guid("8a89450d-119b-436f-8f77-63dcff7c0648"), new DateTime(2024, 1, 26, 22, 5, 44, 154, DateTimeKind.Local).AddTicks(7180), false, null, "Total Gym Exercises for Biceps" },
                    { new Guid("93bf45e9-1e72-43a8-8aee-efbf74761f16"), new DateTime(2024, 1, 26, 22, 5, 44, 154, DateTimeKind.Local).AddTicks(7188), false, null, "Exercise" },
                    { new Guid("a19b27b5-091b-43de-9f1d-9cdfaa1f2b17"), new DateTime(2024, 1, 26, 22, 5, 44, 154, DateTimeKind.Local).AddTicks(7150), false, null, "Total Gym Exercises for Abs (Abdomininals)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.category");
        }
    }
}
