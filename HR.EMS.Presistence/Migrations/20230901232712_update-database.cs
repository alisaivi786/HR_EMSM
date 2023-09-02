using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveNatures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveNatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultDays = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveAllocations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfDays = table.Column<long>(type: "bigint", nullable: false),
                    LeaveTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Period = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_Users_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<long>(type: "bigint", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    RequestingEmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    RowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "LeaveNatures",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RowId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8171), null, null, null, true, false, null, "Travel", new Guid("b5c299ee-5002-45a6-96b6-45de55ff4476") },
                    { 2L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8185), null, null, null, true, false, null, "Local", new Guid("1177f887-20bc-4daf-93b0-7e9f0e37ece3") }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DefaultDays", "DeletedBy", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RowId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8451), null, null, 10, null, true, false, null, "Sick Leave", new Guid("eba6c596-2d2c-4ffc-bd05-bc9e766f499c") },
                    { 2L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8453), null, null, 20, null, true, false, null, "Annual Leave", new Guid("5885a574-87a2-4516-82ed-d3787aa4429d") },
                    { 3L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8455), null, null, 15, null, true, false, null, "Study Leave", new Guid("f215edb1-560c-49ca-a4ff-04cf8194bc23") },
                    { 4L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8471), null, null, 90, null, true, false, null, "Maternal Leave", new Guid("d06759d9-e927-4697-8c4f-acbd2a0eb722") }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RowId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8547), null, null, null, true, false, null, "Admin", new Guid("be0fc40e-3b79-4767-a1c8-48525872fc28") },
                    { 2L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8549), null, null, null, true, false, null, "Employee", new Guid("8a8f6628-f89a-43e4-9599-d00969cc94f3") }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "Approved", "Cancelled", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DateRequested", "DeletedBy", "EmployeeId", "EndDate", "IsActive", "IsDeleted", "LeaveTypeId", "ModifiedBy", "RequestComments", "RequestingEmployeeId", "RowId", "StartDate" },
                values: new object[,]
                {
                    { 1L, true, false, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9761), null, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9770), null, null, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 1L, null, "Vacation leave", 1L, new Guid("c0224489-fef2-4d71-b8e3-f24e54e2cca8"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, false, true, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9774), null, null, new DateTime(2023, 8, 28, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9775), null, null, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2L, null, "Sick leave", 1L, new Guid("d55f634b-8cf0-4770-975f-02bca373487f"), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, true, false, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9791), null, null, new DateTime(2023, 8, 23, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9792), null, null, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3L, null, "Study leave", 1L, new Guid("ca0237a4-4cc4-44a3-8644-9e3f753a4521"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, true, false, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9800), null, null, new DateTime(2023, 8, 18, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9802), null, null, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 1L, null, "Holiday leave", 1L, new Guid("b6292a4c-9602-47cb-b56b-f8a35215e140"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "Email", "FirstName", "IsActive", "IsDeleted", "IsEmailConfirmed", "LastName", "ModifiedBy", "Password", "RoleId", "RowId", "UserName" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9593), null, null, null, "ali.mushtaq@example.com", "Ali", true, false, true, "Mushtaq", null, "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=", 1L, new Guid("d1840b66-2ca8-420b-86d0-df357adb5151"), "alimushtaq" },
                    { 2L, null, new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9598), null, null, null, "junaid.mushtaq@example.com", "Junaid", true, false, true, "Mushtaq", null, "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=", 2L, new Guid("1e1fc135-fa7a-4fb5-89bd-09c6ed078c6b"), "junaidmushtaq" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_EmployeeId",
                table: "LeaveAllocations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                table: "LeaveRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "LeaveNatures");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
