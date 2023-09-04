using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class addSomeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeaveAllocations",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateModified", "DeletedBy", "EmployeeId", "IsActive", "IsDeleted", "LeaveTypeId", "ModifiedBy", "RowId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3742), null, null, null, 1L, true, false, 1L, null, new Guid("2d86d57b-4516-44f6-9c68-dcb739a840b6") },
                    { 2L, null, new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3748), null, null, null, 1L, true, false, 2L, null, new Guid("51d32449-349a-4c29-8f52-d4171e19fed9") },
                    { 3L, null, new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3760), null, null, null, 1L, true, false, 3L, null, new Guid("497fb7e9-5836-443c-adb8-75fe11521d26") },
                    { 4L, null, new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3765), null, null, null, 2L, true, false, 1L, null, new Guid("e831ca4a-7aa7-48b4-958f-68b639000024") },
                    { 5L, null, new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3768), null, null, null, 2L, true, false, 2L, null, new Guid("20181b03-5c75-4f7e-9a51-aed3a219502d") },
                    { 6L, null, new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3773), null, null, null, 2L, true, false, 3L, null, new Guid("ece2c6b3-379a-4941-ad4d-f049b34dd768") },
                    { 7L, null, new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3777), null, null, null, 2L, true, false, 4L, null, new Guid("0a6962c1-46df-477c-8ecd-249b49b7cc99") }
                });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 875, DateTimeKind.Local).AddTicks(7980), new Guid("9a5c0527-9dd9-415a-b327-c5c5514a6054") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 875, DateTimeKind.Local).AddTicks(8001), new Guid("beefd5c5-6ffe-4078-9ba8-291abe2dea00") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3502), new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3516), new Guid("4ad1a6b4-1a98-4e95-a84f-3cc4f6914387") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3524), new DateTime(2023, 8, 30, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3527), new Guid("d5314cb9-7cd2-42fd-8d5d-ab729e4ac623") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 8, 25, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3541), new Guid("3565a511-1ff7-47c1-b725-60e7b5148bdb") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3547), new DateTime(2023, 8, 20, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3550), new Guid("ed40ed59-6f2d-4a5e-81d2-ec77bbc2ec87") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 875, DateTimeKind.Local).AddTicks(8242), new Guid("1639885d-1356-4418-97d5-da11d88f53d9") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 875, DateTimeKind.Local).AddTicks(8246), new Guid("02c2f73a-6f00-4f9d-a839-997a22222b65") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 875, DateTimeKind.Local).AddTicks(8249), new Guid("b4d6e656-3aad-4fc8-a835-1909ff770b17") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 875, DateTimeKind.Local).AddTicks(8252), new Guid("f66cdbb1-d522-4aca-9598-5b81968de2ec") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 875, DateTimeKind.Local).AddTicks(8400), new Guid("73f58538-71a8-482a-901f-0a857606e7bb") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 875, DateTimeKind.Local).AddTicks(8403), new Guid("34edf26a-a61f-4f02-8934-62475742d5a5") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(2852), new Guid("f31ecdce-7a16-41d5-b59d-665954c6e9f1") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(2890), new Guid("c52b0590-ec87-460c-a65d-b8c9690f77fa") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7L);

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
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4312), new Guid("986317c5-075b-4ff1-858a-5ce55d19ab4b") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4322), new Guid("c91bc449-fa03-474e-8276-23de441c3b86") });
        }
    }
}
