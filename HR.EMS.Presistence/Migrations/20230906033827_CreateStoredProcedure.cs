using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateStoredProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2804), new Guid("4d9a296d-da0c-40bb-9dee-6569b53642e9") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2806), new Guid("2e902115-acae-48e9-8964-664c6cdc0209") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2807), new Guid("3ea00ac2-e7b9-4bdc-84a3-c0e1f1740232") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2808), new Guid("6729678d-94d6-4567-893d-cb71aa92fe32") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2810), new Guid("355c4a07-9220-4234-95a8-3a654e7e0408") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2811), new Guid("b8d78ec3-3bb6-478c-8c67-471f6b13a1b2") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2815), new Guid("f584d5cb-2086-4d69-8665-8a060ba0f466") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(1611), new Guid("cbbf534c-e809-4b5c-b672-75882047198b") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(1624), new Guid("45dfbcc0-2c22-4ba5-a7e7-e0ee73178dd1") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2669), new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2673), new Guid("ac4dd745-8e64-4f99-af54-14ba405fbc7f") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 9, 1, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2676), new Guid("e51ef3cb-e67a-4b45-b2cc-305de2506c5d") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2685), new DateTime(2023, 8, 27, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2686), new Guid("15054ec1-01ad-4e25-8f63-0ae8906570b3") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2688), new DateTime(2023, 8, 22, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2689), new Guid("25922136-d904-45be-ad61-fc44a2a4362f") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(1785), new Guid("21fba90d-5471-407d-8eaf-d7186cb8a588") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(1787), new Guid("b1e5c227-3664-42dc-a70c-51aff1c5cdca") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(1803), new Guid("6d90bf5e-bca2-4c45-a5af-d3cde937f7e5") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(1805), new Guid("aaae9cc5-bf45-4b9c-9c56-4c958298a88a") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(1861), new Guid("10f7e035-1242-4d98-808f-4f91c9bbb783") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(1863), new Guid("004424b9-e7c7-46b2-808c-f785f8567304") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2590), new Guid("4ec0f8d0-5c69-472a-9392-7678d7108ffe") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 38, 27, 354, DateTimeKind.Local).AddTicks(2593), new Guid("ecf62f9d-0df7-4282-9383-e0ff71b509f9") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
