using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddGymInterestAreaEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("147685ef-4a69-437a-a094-0872db3deb2c"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("53ba090c-bf88-4670-b798-068155c685e5"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("aba5f6d7-cccd-48ba-8383-98563a5cf1d5"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("bf2b3035-002b-448d-a58b-57eedfe33753"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("fa6ecd08-5b12-43e1-953e-1a80cfb1b9d3"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("fa917e0f-c660-4d35-b1e8-e0ec1a03033d"));

            migrationBuilder.CreateTable(
                name: "gms.gym_interest_area",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Interest = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.gym_interest_area", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.gym_interest_area");

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

            migrationBuilder.InsertData(
                table: "gms.category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("147685ef-4a69-437a-a094-0872db3deb2c"), new DateTime(2024, 1, 26, 23, 0, 58, 302, DateTimeKind.Local).AddTicks(407), false, null, "Limited" },
                    { new Guid("53ba090c-bf88-4670-b798-068155c685e5"), new DateTime(2024, 1, 26, 23, 0, 58, 302, DateTimeKind.Local).AddTicks(414), false, null, "Total Gym Exercises for Legs" },
                    { new Guid("aba5f6d7-cccd-48ba-8383-98563a5cf1d5"), new DateTime(2024, 1, 26, 23, 0, 58, 302, DateTimeKind.Local).AddTicks(411), false, null, "Total Gym Exercises for Abs (Abdomininals)" },
                    { new Guid("bf2b3035-002b-448d-a58b-57eedfe33753"), new DateTime(2024, 1, 26, 23, 0, 58, 302, DateTimeKind.Local).AddTicks(337), false, null, "Regular" },
                    { new Guid("fa6ecd08-5b12-43e1-953e-1a80cfb1b9d3"), new DateTime(2024, 1, 26, 23, 0, 58, 302, DateTimeKind.Local).AddTicks(439), false, null, "Total Gym Exercises for Biceps" },
                    { new Guid("fa917e0f-c660-4d35-b1e8-e0ec1a03033d"), new DateTime(2024, 1, 26, 23, 0, 58, 302, DateTimeKind.Local).AddTicks(447), false, null, "Exercise" }
                });
        }
    }
}
