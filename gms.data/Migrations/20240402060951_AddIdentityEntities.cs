using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.Identity.GymIdentityRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.Identity.GymIdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GymStaffSpecializationEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymStaffSpecializationEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gms.Identity.GymIdentityRoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.Identity.GymIdentityRoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.Identity.GymIdentityRoleClaim_gms.Identity.GymIdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "gms.Identity.GymIdentityRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.Identity.GymIdentityUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<byte>(type: "tinyint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    GymUserTypeId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)2),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GymStaffSpecializationId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.Identity.GymIdentityUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.Identity.GymIdentityUser_GymStaffSpecializationEntity_GymStaffSpecializationId",
                        column: x => x.GymStaffSpecializationId,
                        principalTable: "GymStaffSpecializationEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_gms.Identity.GymIdentityUser_gms.Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "gms.Gym",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.Identity.GymIdentityUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.Identity.GymIdentityUserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.Identity.GymIdentityUserClaim_gms.Identity.GymIdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.Identity.GymIdentityUserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.Identity.GymIdentityUserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_gms.Identity.GymIdentityUserLogin_gms.Identity.GymIdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.Identity.GymIdentityUserRole",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.Identity.GymIdentityUserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_gms.Identity.GymIdentityUserRole_gms.Identity.GymIdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "gms.Identity.GymIdentityRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.Identity.GymIdentityUserRole_gms.Identity.GymIdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.Identity.GymIdentityUserToken",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.Identity.GymIdentityUserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_gms.Identity.GymIdentityUserToken_gms.Identity.GymIdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 760, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 760, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 761, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 762, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 787, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 787, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 787, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 2, 6, 9, 50, 787, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "gms.Identity.GymIdentityRole",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityRoleClaim_RoleId",
                table: "gms.Identity.GymIdentityRoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "gms.Identity.GymIdentityUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymStaffSpecializationId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "gms.Identity.GymIdentityUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUserClaim_UserId",
                table: "gms.Identity.GymIdentityUserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUserLogin_UserId",
                table: "gms.Identity.GymIdentityUserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUserRole_RoleId",
                table: "gms.Identity.GymIdentityUserRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.Identity.GymIdentityRoleClaim");

            migrationBuilder.DropTable(
                name: "gms.Identity.GymIdentityUserClaim");

            migrationBuilder.DropTable(
                name: "gms.Identity.GymIdentityUserLogin");

            migrationBuilder.DropTable(
                name: "gms.Identity.GymIdentityUserRole");

            migrationBuilder.DropTable(
                name: "gms.Identity.GymIdentityUserToken");

            migrationBuilder.DropTable(
                name: "gms.Identity.GymIdentityRole");

            migrationBuilder.DropTable(
                name: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropTable(
                name: "GymStaffSpecializationEntity");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 841, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 842, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 870, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 870, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 870, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 0, 18, 58, 870, DateTimeKind.Utc).AddTicks(1297));
        }
    }
}
