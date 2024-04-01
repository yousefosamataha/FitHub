using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGymUserEntityAddUserType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "00c1c658-a75b-4e39-8305-d23038ebaba7");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "078fa778-fa81-422f-b87d-60bc68bb4042");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "93edc39e-68dc-48de-b7e0-24b4c6f5f2a4");

            migrationBuilder.AddColumn<byte>(
                name: "GymUserTypeId",
                table: "gms.Identity.GymUser",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)2);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "GymUserTypeId",
                table: "gms.Identity.GymUser");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 922, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.InsertData(
                table: "gms.Identity.GymRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00c1c658-a75b-4e39-8305-d23038ebaba7", null, "SuperAdmin", "SUPERADMIN" },
                    { "078fa778-fa81-422f-b87d-60bc68bb4042", null, "Admin", "ADMIN" },
                    { "93edc39e-68dc-48de-b7e0-24b4c6f5f2a4", null, "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 923, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 924, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 924, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 978, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 978, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 978, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 2, 20, 18, 978, DateTimeKind.Utc).AddTicks(6157));
        }
    }
}
