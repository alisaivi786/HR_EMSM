using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "Approved", "Cancelled", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DateRequested", "DeletedBy", "EmployeeId", "EndDate", "IsActive", "IsDeleted", "LeaveTypeId", "ModifiedBy", "RequestComments", "RequestingEmployeeId", "RowId", "StartDate" },
                values: new object[,]
                {
                    { 1L, true, false, null, null, null, null, new DateTime(2023, 9, 1, 7, 20, 33, 395, DateTimeKind.Local).AddTicks(3083), null, null, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 1L, null, "Vacation leave", 1L, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, false, true, null, null, null, null, new DateTime(2023, 8, 27, 7, 20, 33, 395, DateTimeKind.Local).AddTicks(3093), null, null, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2L, null, "Sick leave", 1L, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, true, false, null, null, null, null, new DateTime(2023, 8, 22, 7, 20, 33, 395, DateTimeKind.Local).AddTicks(3100), null, null, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3L, null, "Study leave", 1L, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, true, false, null, null, null, null, new DateTime(2023, 8, 17, 7, 20, 33, 395, DateTimeKind.Local).AddTicks(3102), null, null, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 1L, null, "Holiday leave", 1L, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L);
        }
    }
}
