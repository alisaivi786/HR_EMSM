using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateStoredProcedure2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6007), new Guid("f08bf6bc-3881-4a76-b144-f8480150901f") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6009), new Guid("c70d315a-d3f0-43a8-8def-97b7d1f2c529") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6012), new Guid("342ca087-78c2-4082-a844-acfc5385d6d2") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6013), new Guid("1c317f20-2312-45fe-8ab1-09dff00a779b") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6015), new Guid("59e1ee54-9241-41f1-8ba9-9d06c8059d7d") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6016), new Guid("5ddb8a4a-acbf-4f83-9f47-7b68af818662") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6017), new Guid("9ee11b81-e84f-42ba-9a8f-ebfd66e28f4e") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(4893), new Guid("901e3621-0ba7-45d7-8d29-8b88c3db2780") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(4914), new Guid("bba7a52d-c6fa-4eaf-b2d2-d56edcffb03e") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5915), new Guid("2b2cbaa9-71a8-453f-befa-c8bcc0d4b22e") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 9, 1, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5918), new Guid("ad36afc3-56cc-4689-8006-f432c1556d5e") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 8, 27, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5930), new Guid("a18b86cb-3541-4732-940f-acf2eea0a055") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 8, 22, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5933), new Guid("ee0a6d08-ee98-4169-9f60-e0c531818792") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5031), new Guid("6f274874-9574-4bd8-848e-0ec4bf4e6c77") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5033), new Guid("d693b8f5-dd57-451b-92a8-5734b93e3d16") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5035), new Guid("59713578-5695-49a7-ad02-1e3aa0a52db6") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5036), new Guid("416997b2-4672-4327-b5a4-4d660e069ab0") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5103), new Guid("19e73d8c-9a41-4c7f-bac2-4df69afe0b52") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5105), new Guid("5b0797e3-95d7-4736-b35c-e59c3bf45f93") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5820), new Guid("aacc6181-1db3-45c3-a456-51ad6c497a97") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5824), new Guid("2e5afa0d-162e-4fca-aa0b-283ea1504aec") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
