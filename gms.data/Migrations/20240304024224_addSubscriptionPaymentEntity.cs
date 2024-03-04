using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class addSubscriptionPaymentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.SubscriptionPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<byte>(type: "tinyint", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.SubscriptionPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.SubscriptionPayment_gms.SystemSubscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "gms.SystemSubscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 919, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 919, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 919, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 919, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 919, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 919, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 919, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 919, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 920, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 920, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 920, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 42, 23, 920, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.CreateIndex(
                name: "IX_gms.SubscriptionPayment_SubscriptionId",
                table: "gms.SubscriptionPayment",
                column: "SubscriptionId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.SubscriptionPayment");

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 882, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 882, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 2, 5, 22, 883, DateTimeKind.Utc).AddTicks(6358));
        }
    }
}
