using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddGymEventPlaceEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("04ec7783-f082-4ee1-9d85-e8bd0d65a9da"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("10c0d450-fa01-451f-8a1f-ce8f9155f4c4"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("11c076f9-ff15-4902-87b1-18d67328cf03"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("8a89450d-119b-436f-8f77-63dcff7c0648"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("93bf45e9-1e72-43a8-8aee-efbf74761f16"));

            migrationBuilder.DeleteData(
                table: "gms.category",
                keyColumn: "Id",
                keyValue: new Guid("a19b27b5-091b-43de-9f1d-9cdfaa1f2b17"));

            migrationBuilder.CreateTable(
                name: "gms.gym_event_place",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.gym_event_place", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.gym_event_place");

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
    }
}
