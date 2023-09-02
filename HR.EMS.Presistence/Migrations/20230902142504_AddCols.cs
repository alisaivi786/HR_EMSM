using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCols : Migration
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
                    ProcessingDuration = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(2516), new Guid("7be9d1d0-c9cb-4cfc-b30d-ab167e7f6cbe") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(2552), new Guid("59260370-ad87-4a70-a47f-bcd3d2a046f9") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5216), new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5222), new Guid("f7c493e9-d0f4-49cd-ab57-36e9900f93e8") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5226), new DateTime(2023, 8, 28, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5227), new Guid("de088be8-abfa-44ca-8fe0-cb052af36c00") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 8, 23, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5236), new Guid("db805e68-b665-4bf5-b776-1a59b2bba343") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5239), new DateTime(2023, 8, 18, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5241), new Guid("aabd2285-e0af-4e2e-adc3-7af76f28f026") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(2900), new Guid("bd5ffce5-488f-4058-9023-25bb079a2609") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(2904), new Guid("536de200-fda2-4d3b-9f82-630af05ec732") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(2906), new Guid("a2026bf1-6c76-41be-b6ed-a5d82ecc4464") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(2910), new Guid("3e083705-b4d7-40df-b67a-022e4920689c") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(3015), new Guid("52c40810-8c20-4319-9531-81117c8d0d87") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(3018), new Guid("458fe9f0-a448-44fc-a80c-146526649a5e") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5037), new Guid("298f44ae-d1e5-497d-bff4-2a5380d0b4f9") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 18, 25, 3, 753, DateTimeKind.Local).AddTicks(5059), new Guid("5757a19f-b1b3-4aa1-a950-9e34cac9198c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiLogs");

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8171), new Guid("b5c299ee-5002-45a6-96b6-45de55ff4476") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8185), new Guid("1177f887-20bc-4daf-93b0-7e9f0e37ece3") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9761), new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9770), new Guid("c0224489-fef2-4d71-b8e3-f24e54e2cca8") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 8, 28, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9775), new Guid("d55f634b-8cf0-4770-975f-02bca373487f") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9791), new DateTime(2023, 8, 23, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9792), new Guid("ca0237a4-4cc4-44a3-8644-9e3f753a4521") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 8, 18, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9802), new Guid("b6292a4c-9602-47cb-b56b-f8a35215e140") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8451), new Guid("eba6c596-2d2c-4ffc-bd05-bc9e766f499c") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8453), new Guid("5885a574-87a2-4516-82ed-d3787aa4429d") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8455), new Guid("f215edb1-560c-49ca-a4ff-04cf8194bc23") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8471), new Guid("d06759d9-e927-4697-8c4f-acbd2a0eb722") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8547), new Guid("be0fc40e-3b79-4767-a1c8-48525872fc28") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(8549), new Guid("8a8f6628-f89a-43e4-9599-d00969cc94f3") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9593), new Guid("d1840b66-2ca8-420b-86d0-df357adb5151") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 3, 27, 11, 886, DateTimeKind.Local).AddTicks(9598), new Guid("1e1fc135-fa7a-4fb5-89bd-09c6ed078c6b") });
        }
    }
}
