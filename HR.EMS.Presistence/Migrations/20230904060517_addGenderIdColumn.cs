using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class addGenderIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "GenderId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(2834), new Guid("9a82969e-f7c1-4463-bc04-533e7d116cf2") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(2868), new Guid("e1949670-9e8d-4713-88cd-5e85f431682a") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4434), new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4443), new Guid("8fdb9530-a87d-4f20-886d-740c52a17f65") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 8, 30, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4449), new Guid("76a6c16e-5835-4f3e-b7ac-2f240849fd9f") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4456), new DateTime(2023, 8, 25, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4458), new Guid("5fe7f10b-5254-4f2e-b8fe-146daa9b1106") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 8, 20, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4462), new Guid("0233e006-7f7b-460a-9b68-fb259f85a6fb") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3111), new Guid("91f3bbb4-7dd0-4b30-9be7-ed7035c508a6") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3115), new Guid("a925af0e-7117-40de-abb2-637ca988636b") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3117), new Guid("5438a93f-715a-49ce-83d2-31dbada059e6") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3119), new Guid("bb9e9030-107b-4c45-b470-4e6d23c42138") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3208), new Guid("e309e97c-ee26-484e-aeae-0468aeb9d7f1") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3210), new Guid("a6d2b94c-7fe8-4fed-ae82-0a494d08b3db") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "GenderId", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4312), null, new Guid("986317c5-075b-4ff1-858a-5ce55d19ab4b") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "GenderId", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4322), null, new Guid("c91bc449-fa03-474e-8276-23de441c3b86") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Users");

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
    }
}
