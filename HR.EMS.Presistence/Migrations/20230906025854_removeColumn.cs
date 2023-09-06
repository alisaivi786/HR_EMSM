using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class removeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponseHeaders",
                table: "ApiLogs");

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1844), new Guid("417a0654-ca9c-4080-aa23-e33455c30e34") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1846), new Guid("c16db90f-b957-4779-9fa8-f2060b265ecd") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1847), new Guid("2ce61276-04aa-47fd-8237-004ec42b9115") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1848), new Guid("fb7c5a46-9def-4520-bc16-2e0c42b29f63") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1850), new Guid("745f0080-4630-4fba-a959-4ab7b4d61f64") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1851), new Guid("84850a6d-74d8-4766-89b8-47bbd7ec9c64") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1854), new Guid("37c33866-a754-4c35-b3e7-1a40fb8105ec") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(632), new Guid("fc95c8db-48b7-498e-9f7a-d7af02e7e9f8") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(647), new Guid("5a94b925-6627-4dc4-b78b-bab76270cc83") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1753), new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1757), new Guid("ec33e875-5b22-4214-a7bf-b9d57f8df666") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1759), new DateTime(2023, 9, 1, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1761), new Guid("22b267d2-3243-437e-bf58-5bd197064aa0") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1771), new DateTime(2023, 8, 27, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1772), new Guid("39630f6e-708f-4f0f-83a3-50a51eed54c6") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 8, 22, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1775), new Guid("78fb96ed-e90b-4307-9e68-2ee0e0334e0e") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(776), new Guid("0d3bbfeb-9fa0-4672-ad48-a5258bc71d93") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(778), new Guid("98b517cf-004c-4118-97cc-bc66e5558ef9") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(793), new Guid("33339f97-a6c7-4989-9e6d-543c61fd1fbf") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(794), new Guid("79adbfc9-b0b6-4f2b-b5fa-8d77f4c1678c") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(854), new Guid("1d3d7bec-d2c3-44a2-ad04-d9d7556addd9") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(856), new Guid("fc282608-5093-4266-ad89-a20e5a340bb2") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1661), new Guid("e5d3ad91-7d3d-4ee4-a63e-5dbabff3df02") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1664), new Guid("21c931dc-392e-4e24-a4df-ac0e69999bc0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResponseHeaders",
                table: "ApiLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3742), new Guid("2d86d57b-4516-44f6-9c68-dcb739a840b6") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3748), new Guid("51d32449-349a-4c29-8f52-d4171e19fed9") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3760), new Guid("497fb7e9-5836-443c-adb8-75fe11521d26") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3765), new Guid("e831ca4a-7aa7-48b4-958f-68b639000024") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3768), new Guid("20181b03-5c75-4f7e-9a51-aed3a219502d") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3773), new Guid("ece2c6b3-379a-4941-ad4d-f049b34dd768") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 4, 10, 19, 11, 876, DateTimeKind.Local).AddTicks(3777), new Guid("0a6962c1-46df-477c-8ecd-249b49b7cc99") });

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
    }
}
