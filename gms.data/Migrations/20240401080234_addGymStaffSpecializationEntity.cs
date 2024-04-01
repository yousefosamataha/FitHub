using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class addGymStaffSpecializationEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "0685cd90-246f-4435-8bd7-0be2224ade2a");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "3fb4919a-7484-4d92-b051-994a0aac9bd8");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "73721a25-818a-45f7-af14-8632483983aa");

            migrationBuilder.AddColumn<int>(
                name: "GymStaffSpecializationId",
                table: "gms.Identity.GymUser",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "gms.GymStaffSpecialization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymStaffSpecialization", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.InsertData(
                table: "gms.Identity.GymRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a3e6974-cfaa-4461-9d8d-8e085c4d0236", null, "Basic", "BASIC" },
                    { "5b92ec3e-b099-4c63-a96e-429fc90ab80f", null, "SuperAdmin", "SUPERADMIN" },
                    { "9c4cb3f6-be78-4151-bd52-3ba84b1dea00", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 33, 1, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 33, 1, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 33, 1, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 33, 1, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymUser_GymStaffSpecializationId",
                table: "gms.Identity.GymUser",
                column: "GymStaffSpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymUser_gms.GymStaffSpecialization_GymStaffSpecializationId",
                table: "gms.Identity.GymUser",
                column: "GymStaffSpecializationId",
                principalTable: "gms.GymStaffSpecialization",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymUser_gms.GymStaffSpecialization_GymStaffSpecializationId",
                table: "gms.Identity.GymUser");

            migrationBuilder.DropTable(
                name: "gms.GymStaffSpecialization");

            migrationBuilder.DropIndex(
                name: "IX_gms.Identity.GymUser_GymStaffSpecializationId",
                table: "gms.Identity.GymUser");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "4a3e6974-cfaa-4461-9d8d-8e085c4d0236");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "5b92ec3e-b099-4c63-a96e-429fc90ab80f");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "9c4cb3f6-be78-4151-bd52-3ba84b1dea00");

            migrationBuilder.DropColumn(
                name: "GymStaffSpecializationId",
                table: "gms.Identity.GymUser");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.InsertData(
                table: "gms.Identity.GymRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0685cd90-246f-4435-8bd7-0be2224ade2a", null, "Admin", "ADMIN" },
                    { "3fb4919a-7484-4d92-b051-994a0aac9bd8", null, "SuperAdmin", "SUPERADMIN" },
                    { "73721a25-818a-45f7-af14-8632483983aa", null, "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 55, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 56, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 105, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 105, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 105, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 42, 12, 105, DateTimeKind.Utc).AddTicks(4515));
        }
    }
}
