using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestHeaders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: false),
                    ResponseHeaders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ElapsedMilliseconds = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ApiLogs", x => x.Id);
                });

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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LeaveNatures",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RowId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(6082), null, null, null, true, false, null, "Travel", new Guid("7652a302-6712-4a26-87b8-293813e894a0") },
                    { 2L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(6097), null, null, null, true, false, null, "Local", new Guid("63f1f7db-a068-4106-9b88-f4cc9da688cd") }
                });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DefaultDays", "DeletedBy", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RowId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(6474), null, null, 10, null, true, false, null, "Sick Leave", new Guid("31a63f11-bf82-4d5f-8a8a-d799df0214d4") },
                    { 2L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(7036), null, null, 20, null, true, false, null, "Annual Leave", new Guid("a8d35cfb-d83f-428f-8cd6-eab49a3cd551") },
                    { 3L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(7043), null, null, 15, null, true, false, null, "Study Leave", new Guid("131671fc-a9e2-4859-8308-7a29f3603525") },
                    { 4L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(7046), null, null, 90, null, true, false, null, "Maternal Leave", new Guid("72927656-e38e-40cb-b83c-484934e66da2") }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RowId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(7198), null, null, null, true, false, null, "Admin", new Guid("e9546ff5-09ac-445a-82ca-bf8180658534") },
                    { 2L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(7224), null, null, null, true, false, null, "Employee", new Guid("013536d9-7166-4761-8508-7715199ce1d8") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "Email", "FirstName", "IsActive", "IsDeleted", "IsEmailConfirmed", "LastName", "ModifiedBy", "Password", "RoleId", "RowId", "UserName" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8725), null, null, null, "ali.mushtaq@example.com", "Ali", true, false, true, "Mushtaq", null, "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=", 1L, new Guid("b0925a75-d802-4b9a-979a-68aa2e71a2ac"), "alimushtaq" },
                    { 2L, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8734), null, null, null, "junaid.mushtaq@example.com", "Junaid", true, false, true, "Mushtaq", null, "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=", 2L, new Guid("b551c0f9-cf96-4cea-bb04-37fd1b86dc20"), "junaidmushtaq" }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "Approved", "Cancelled", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DateRequested", "DeletedBy", "EmployeeId", "EndDate", "IsActive", "IsDeleted", "LeaveTypeId", "ModifiedBy", "RequestComments", "RowId", "StartDate" },
                values: new object[,]
                {
                    { 1L, true, false, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8893), null, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8901), null, 1L, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 1L, null, "Vacation leave", new Guid("9d8a2350-ef6a-4cdd-83ba-3745f3ef7231"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, false, true, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8905), null, null, new DateTime(2023, 8, 30, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8907), null, 1L, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2L, null, "Sick leave", new Guid("bf243d75-9880-4733-9aad-4512d7ddbde2"), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, true, false, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8917), null, null, new DateTime(2023, 8, 25, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8919), null, 1L, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3L, null, "Study leave", new Guid("111c84bd-e71a-4ad0-847b-08f803b46b27"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, true, false, null, new DateTime(2023, 9, 4, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8922), null, null, new DateTime(2023, 8, 20, 4, 19, 46, 992, DateTimeKind.Local).AddTicks(8924), null, 1L, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 1L, null, "Holiday leave", new Guid("5813624b-4615-4734-95ce-6abf6a2fe78a"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "ApiLogs");

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
