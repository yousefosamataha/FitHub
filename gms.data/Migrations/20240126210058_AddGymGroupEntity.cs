using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddGymGroupEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("12220ade-9671-444b-a15f-a92c023ecc2b"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("13c825c4-b6c2-449d-ba97-7f552e17cce7"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("2b131b6a-0f99-43be-ba1b-2f3f4e440940"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("a98e2629-0768-4b45-8d02-bae3a216f60b"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("dae0c103-e52d-459d-b5c9-6d02dcbf59f5"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("ebcbe191-6fef-47c0-9fe0-34216dcd194b"));

            migrationBuilder.CreateTable(
                name: "gms.gym_group",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.gym_group", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.gym_group");

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

            migrationBuilder.InsertData(
                table: "gms.category",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("12220ade-9671-444b-a15f-a92c023ecc2b"), new DateTime(2024, 1, 26, 22, 59, 3, 518, DateTimeKind.Local).AddTicks(1234), false, null, "Total Gym Exercises for Biceps" },
                    { new Guid("13c825c4-b6c2-449d-ba97-7f552e17cce7"), new DateTime(2024, 1, 26, 22, 59, 3, 518, DateTimeKind.Local).AddTicks(1231), false, null, "Total Gym Exercises for Legs" },
                    { new Guid("2b131b6a-0f99-43be-ba1b-2f3f4e440940"), new DateTime(2024, 1, 26, 22, 59, 3, 518, DateTimeKind.Local).AddTicks(1222), false, null, "Limited" },
                    { new Guid("a98e2629-0768-4b45-8d02-bae3a216f60b"), new DateTime(2024, 1, 26, 22, 59, 3, 518, DateTimeKind.Local).AddTicks(1241), false, null, "Exercise" },
                    { new Guid("dae0c103-e52d-459d-b5c9-6d02dcbf59f5"), new DateTime(2024, 1, 26, 22, 59, 3, 518, DateTimeKind.Local).AddTicks(1227), false, null, "Total Gym Exercises for Abs (Abdomininals)" },
                    { new Guid("ebcbe191-6fef-47c0-9fe0-34216dcd194b"), new DateTime(2024, 1, 26, 22, 59, 3, 518, DateTimeKind.Local).AddTicks(1135), false, null, "Regular" }
                });
        }
    }
}
