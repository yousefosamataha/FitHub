using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddActivityEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActivityEntityId",
                table: "gms.ActivityVideo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "gms.Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ActivityCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.Activity_gms.ActivityCategory_ActivityCategoryId",
                        column: x => x.ActivityCategoryId,
                        principalTable: "gms.ActivityCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 292, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 292, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 292, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 292, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 292, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 292, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 292, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 292, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 293, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 293, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 300, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 300, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 300, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 23, 2, 29, 300, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.CreateIndex(
                name: "IX_gms.ActivityVideo_ActivityEntityId",
                table: "gms.ActivityVideo",
                column: "ActivityEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Activity_ActivityCategoryId",
                table: "gms.Activity",
                column: "ActivityCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ActivityVideo_gms.Activity_ActivityEntityId",
                table: "gms.ActivityVideo",
                column: "ActivityEntityId",
                principalTable: "gms.Activity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ActivityVideo_gms.Activity_ActivityEntityId",
                table: "gms.ActivityVideo");

            migrationBuilder.DropTable(
                name: "gms.Activity");

            migrationBuilder.DropIndex(
                name: "IX_gms.ActivityVideo_ActivityEntityId",
                table: "gms.ActivityVideo");

            migrationBuilder.DropColumn(
                name: "ActivityEntityId",
                table: "gms.ActivityVideo");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 402, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 411, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 411, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 411, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 22, 48, 4, 411, DateTimeKind.Utc).AddTicks(1419));
        }
    }
}
