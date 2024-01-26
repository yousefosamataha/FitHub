using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddGymLevelEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("1f587690-2567-4633-adb3-64d5f590c916"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("6353a480-efdc-4512-996f-1ddf39dcbd31"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("87702882-51a4-4926-a362-ad4b13482e2c"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("b59c7106-26cf-420b-a529-e5aa9225b9ea"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("c5072230-ae51-443e-9a75-40857b084a7f"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("edcd2a1f-e190-4dd5-8d7a-98f6f9a57527"));

            migrationBuilder.CreateTable(
                name: "gms.gym_levels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.gym_levels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "gms.category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1d9feabc-27cc-43d6-a9f1-47785c4af200"), new DateTime(2024, 1, 26, 23, 10, 30, 128, DateTimeKind.Local).AddTicks(8681), false, null, "Regular" },
                    { new Guid("3fe45a27-1ae8-42b1-accf-2f512284c2a6"), new DateTime(2024, 1, 26, 23, 10, 30, 128, DateTimeKind.Local).AddTicks(8823), false, null, "Total Gym Exercises for Legs" },
                    { new Guid("82f7936b-90cc-4f5d-bbf2-8ad9d1c8e9db"), new DateTime(2024, 1, 26, 23, 10, 30, 128, DateTimeKind.Local).AddTicks(8835), false, null, "Exercise" },
                    { new Guid("9aea944f-a256-4712-8500-089f43078b8a"), new DateTime(2024, 1, 26, 23, 10, 30, 128, DateTimeKind.Local).AddTicks(8820), false, null, "Total Gym Exercises for Abs (Abdomininals)" },
                    { new Guid("d8878e02-a940-4615-af6e-7202c6615532"), new DateTime(2024, 1, 26, 23, 10, 30, 128, DateTimeKind.Local).AddTicks(8814), false, null, "Limited" },
                    { new Guid("f2c7f5ea-10ae-4438-ba0b-17d0679da74a"), new DateTime(2024, 1, 26, 23, 10, 30, 128, DateTimeKind.Local).AddTicks(8827), false, null, "Total Gym Exercises for Biceps" }
                });

            migrationBuilder.InsertData(
                table: "gms.gym_levels",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Level", "ModifiedAt" },
                values: new object[] { new Guid("ffe704ac-9d79-4c00-8d05-fdffb3a49c69"), new DateTime(2024, 1, 26, 23, 10, 30, 129, DateTimeKind.Local).AddTicks(9066), false, "Level 1", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.gym_levels");

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("1d9feabc-27cc-43d6-a9f1-47785c4af200"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("3fe45a27-1ae8-42b1-accf-2f512284c2a6"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("82f7936b-90cc-4f5d-bbf2-8ad9d1c8e9db"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("9aea944f-a256-4712-8500-089f43078b8a"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("d8878e02-a940-4615-af6e-7202c6615532"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("f2c7f5ea-10ae-4438-ba0b-17d0679da74a"));

            migrationBuilder.InsertData(
                table: "gms.category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1f587690-2567-4633-adb3-64d5f590c916"), new DateTime(2024, 1, 26, 23, 3, 49, 50, DateTimeKind.Local).AddTicks(5765), false, null, "Total Gym Exercises for Legs" },
                    { new Guid("6353a480-efdc-4512-996f-1ddf39dcbd31"), new DateTime(2024, 1, 26, 23, 3, 49, 50, DateTimeKind.Local).AddTicks(5768), false, null, "Total Gym Exercises for Biceps" },
                    { new Guid("87702882-51a4-4926-a362-ad4b13482e2c"), new DateTime(2024, 1, 26, 23, 3, 49, 50, DateTimeKind.Local).AddTicks(5761), false, null, "Total Gym Exercises for Abs (Abdomininals)" },
                    { new Guid("b59c7106-26cf-420b-a529-e5aa9225b9ea"), new DateTime(2024, 1, 26, 23, 3, 49, 50, DateTimeKind.Local).AddTicks(5799), false, null, "Exercise" },
                    { new Guid("c5072230-ae51-443e-9a75-40857b084a7f"), new DateTime(2024, 1, 26, 23, 3, 49, 50, DateTimeKind.Local).AddTicks(5758), false, null, "Limited" },
                    { new Guid("edcd2a1f-e190-4dd5-8d7a-98f6f9a57527"), new DateTime(2024, 1, 26, 23, 3, 49, 50, DateTimeKind.Local).AddTicks(5690), false, null, "Regular" }
                });
        }
    }
}
