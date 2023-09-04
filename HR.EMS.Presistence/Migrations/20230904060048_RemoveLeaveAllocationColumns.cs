using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLeaveAllocationColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(445), new Guid("bfe98761-a0ed-4c8e-abca-f6da189e92c9") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(457), new Guid("aba7f444-f97f-4bf7-9821-99e6d5581516") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1799), new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1805), new Guid("a0c9e329-8662-45b9-93b3-095bc5f95ab3") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 8, 30, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1810), new Guid("421d8978-f242-4f91-98e2-30ae994f5734") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1816), new DateTime(2023, 8, 25, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1818), new Guid("5c68e68a-bd29-4817-87c2-abb187e82097") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1821), new DateTime(2023, 8, 20, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1823), new Guid("019d2315-f4a0-4cf2-bf4e-d868855853d0") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(630), new Guid("e524d735-9843-485f-b5fd-988fdd1facd6") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(633), new Guid("8b404eba-7976-40c6-9916-5ab56dd9f295") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(636), new Guid("08ea2de3-19ac-4519-abdf-aebbc21471f3") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(638), new Guid("b21cf7ea-2555-42c1-8757-92a99d16810a") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(730), new Guid("508da4e1-201c-4ef4-8a57-4a7bba5ecbf1") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(753), new Guid("1805ff84-1384-47ac-8e9c-a03a2b4a4c5f") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1691), new Guid("6e5fd214-8147-4c2a-80ae-f196081c80cd") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1696), new Guid("3e60f9f3-c7d5-4d53-82d4-71e6e3f09aa4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "NumberOfDays",
                table: "LeaveAllocations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Period",
                table: "LeaveAllocations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(1632), new Guid("81a5c140-8c80-408f-a66e-72daf51a77b0") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(1646), new Guid("974c3ba3-319a-4b3f-a0bb-8e115fe70718") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(3053), new Guid("7df5d8df-fc49-417a-85db-bdba9e440ad8") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 8, 30, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(3056), new Guid("f54c7986-3167-4473-b540-df59513f1d66") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 8, 25, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(3066), new Guid("f43777e3-ee18-4457-8b18-cd0010344e39") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(3068), new DateTime(2023, 8, 20, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(3070), new Guid("793d9b79-b3b4-455f-af5e-4da7c33ab064") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(1876), new Guid("ebf2097d-5656-4639-94a9-902e6d02b1f1") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(1878), new Guid("4634b8cb-5fe7-4816-bf7a-11830be4b50b") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(1881), new Guid("2c9dced9-8921-419c-9dfe-b78bbae496fd") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(1882), new Guid("a31b5c65-1963-48d5-9835-bebb3e119232") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(2039), new Guid("a30c9c10-c445-4784-bf59-2bc0c20d2339") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(2042), new Guid("8b3bab9e-110d-4856-892c-89708ef46f48") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(2855), new Guid("d120e59a-23c5-4bca-be81-f684a6b9bee0") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 8, 44, 43, 716, DateTimeKind.Local).AddTicks(2859), new Guid("f3f78573-7925-4c53-b61b-3e0c168b81be") });
        }
    }
}
