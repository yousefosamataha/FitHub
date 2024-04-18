using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class AddGymMemberGroupAndGymStaffGroupEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.GymMemberGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymMemberUserId = table.Column<int>(type: "int", nullable: false),
                    GymGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymMemberGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymMemberGroup_gms.GymGroup_GymGroupId",
                        column: x => x.GymGroupId,
                        principalTable: "gms.GymGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.GymMemberGroup_gms.Identity.GymIdentityUser_GymMemberUserId",
                        column: x => x.GymMemberUserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.GymStaffGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymStaffUserId = table.Column<int>(type: "int", nullable: false),
                    GymGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymStaffGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymStaffGroup_gms.GymGroup_GymGroupId",
                        column: x => x.GymGroupId,
                        principalTable: "gms.GymGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.GymStaffGroup_gms.Identity.GymIdentityUser_GymStaffUserId",
                        column: x => x.GymStaffUserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 232, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 232, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 272, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 272, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 272, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 272, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 272, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 272, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 272, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 279, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 279, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 279, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 281, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 281, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 282, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 282, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 282, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 282, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 282, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 282, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 282, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 282, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 286, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 286, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 287, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 287, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 287, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 9, 20, 30, 287, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMemberGroup_GymGroupId",
                table: "gms.GymMemberGroup",
                column: "GymGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMemberGroup_GymMemberUserId",
                table: "gms.GymMemberGroup",
                column: "GymMemberUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymStaffGroup_GymGroupId",
                table: "gms.GymStaffGroup",
                column: "GymGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymStaffGroup_GymStaffUserId",
                table: "gms.GymStaffGroup",
                column: "GymStaffUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.GymMemberGroup");

            migrationBuilder.DropTable(
                name: "gms.GymStaffGroup");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 345, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 345, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 365, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 365, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 365, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 365, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 365, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 365, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 365, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 369, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 369, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 369, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 370, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 370, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 371, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 371, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 371, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 371, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 371, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 371, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 371, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 371, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 373, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 373, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 373, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 373, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 373, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 7, 27, 58, 373, DateTimeKind.Utc).AddTicks(5634));
        }
    }
}
