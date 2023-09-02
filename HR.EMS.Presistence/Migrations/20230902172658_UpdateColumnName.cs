using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProcessingDuration",
                table: "ApiLogs",
                newName: "ElapsedMilliseconds");

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(7023), new Guid("ce9a14a9-8757-4039-999e-e2663a327dcf") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(7052), new Guid("5761fd1b-63fc-43af-a53e-fa3d938c2fff") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9833), new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9842), new Guid("f79ce49e-d1d9-4160-a43f-9cb1dc0ea064") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9845), new DateTime(2023, 8, 28, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9846), new Guid("17a80d28-2a3f-46b3-9ae0-8c4bd960f3a3") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9853), new DateTime(2023, 8, 23, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9855), new Guid("ec77f04b-82ce-44ec-a107-114fa1ea2326") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9857), new DateTime(2023, 8, 18, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9858), new Guid("000e9e5a-27c4-4a58-b1e1-823e17a50d98") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(7466), new Guid("b1d086e8-f4a6-4437-a204-26ee72d62e00") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(7471), new Guid("2ff0c5a9-cf59-4ba1-a75b-1687848f857d") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(7474), new Guid("eb3b10c7-7e3d-48e4-b792-69d27d9b12f7") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(7476), new Guid("77989047-15e6-416e-8187-2cd9fb0d5478") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(7749), new Guid("230bb65c-c714-4218-8768-b0e56e0993d8") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(7753), new Guid("fd5d91bd-f2d0-4d9d-81f1-88acf741d186") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9614), new Guid("440b3b39-8b1f-4d9e-be30-df42df3738b3") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 2, 21, 26, 58, 177, DateTimeKind.Local).AddTicks(9626), new Guid("662a6b9d-0552-4ffd-939f-01373337a039") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ElapsedMilliseconds",
                table: "ApiLogs",
                newName: "ProcessingDuration");

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
    }
}
