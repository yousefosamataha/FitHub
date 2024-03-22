using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddGymMeasurementEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeasurementId",
                table: "gms.MeasurementImage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "gms.GymMeasurement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultMeasurementId = table.Column<byte>(type: "tinyint", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymMeasurement", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 368, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 368, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 368, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 368, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.CreateIndex(
                name: "IX_gms.MeasurementImage_MeasurementId",
                table: "gms.MeasurementImage",
                column: "MeasurementId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MeasurementImage_gms.GymMeasurement_MeasurementId",
                table: "gms.MeasurementImage",
                column: "MeasurementId",
                principalTable: "gms.GymMeasurement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.MeasurementImage_gms.GymMeasurement_MeasurementId",
                table: "gms.MeasurementImage");

            migrationBuilder.DropTable(
                name: "gms.GymMeasurement");

            migrationBuilder.DropIndex(
                name: "IX_gms.MeasurementImage_MeasurementId",
                table: "gms.MeasurementImage");

            migrationBuilder.DropColumn(
                name: "MeasurementId",
                table: "gms.MeasurementImage");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 683, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 683, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 683, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 683, DateTimeKind.Utc).AddTicks(1125));
        }
    }
}
