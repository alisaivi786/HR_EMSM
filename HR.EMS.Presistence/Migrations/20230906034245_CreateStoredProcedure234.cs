using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateStoredProcedure234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2928), new Guid("506393b6-0aa2-48c6-84e0-3a282019a61f") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2929), new Guid("e780fdc4-d1cf-4b25-b170-bcb57790a577") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2931), new Guid("757e2e20-2e9b-4105-93c2-0cd3d1317a6d") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2932), new Guid("0b528019-61e6-41a2-a7e3-202ff3ac73b8") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2934), new Guid("71e58778-0a5d-46ee-8c19-3c76cb2927b0") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2935), new Guid("664829c0-0b79-4d04-b455-3be9ca0d3196") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2974), new Guid("a80dd90c-cf10-4c01-a212-a5bd032e9797") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1649), new Guid("c8173f5e-f0fd-4569-ada7-fe6811fa11b5") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1668), new Guid("31852682-baa7-475f-b6a4-cb891dc48e9c") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2846), new Guid("b00057c2-cbe8-4e3a-9bdf-3b32e4b1b29b") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 9, 1, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2849), new Guid("6699f6e4-28f8-4c48-9cb0-f29c124be4a7") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 8, 27, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2855), new Guid("f9f04d1a-f8e7-47ea-96db-6c5a5355c008") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 8, 22, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2858), new Guid("4ed5bdb4-7fcd-4406-bf6d-e9ffaa69d30f") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1795), new Guid("0eb0673d-6ce6-4f1a-9e55-63ab22482373") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1797), new Guid("9742a75e-3b9e-4d37-a2b2-bb93b6eebb0c") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1798), new Guid("0b8b4a7a-10f9-43d7-9c96-f622d9607ad7") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1799), new Guid("8273e7b4-3515-40b2-8c12-aed4f33d099f") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1884), new Guid("fa577186-451a-416e-ac22-6a457b5af2b4") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1886), new Guid("104f1ea2-921a-4c1a-8424-2751603c42ed") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2714), new Guid("b4720c3b-275a-49bc-8107-bec4694f1ceb") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2719), new Guid("c36280c3-d849-4776-b2b1-3834e3f04035") });

            //STORE

            // Read and execute the SQL script for your stored procedure
            var sqlScript = File.ReadAllText("D:\\Angular Dev\\HR_EMS\\HR.EMS.Presistence\\StoredProcedures\\SP_CreateCalculateLeaveSummaryByEmployee.sql");
            migrationBuilder.Sql(sqlScript);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8542), new Guid("e9fb429a-68b1-4725-8535-6b82904fc1d1") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8544), new Guid("2b2d10fd-55e6-41cb-a41f-24a278c047c5") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8545), new Guid("1e1c947d-f9be-4e8b-a243-a2d415f07b9e") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8547), new Guid("9d15e9ac-1117-44b9-9e86-4c4d71b5a058") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8550), new Guid("adf7b2f8-da81-4768-932c-c1965d5b35da") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8551), new Guid("0f87d14e-1233-4c36-a880-07cd6c998f4b") });

            migrationBuilder.UpdateData(
                table: "LeaveAllocations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8553), new Guid("22d02862-d3dd-4329-94b1-4936c7b6a3d1") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(7380), new Guid("9e5996f6-49d9-4036-9e5d-5d5d0b722a62") });

            migrationBuilder.UpdateData(
                table: "LeaveNatures",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(7393), new Guid("7c1081c9-65da-44ff-b413-68059480ad0c") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8461), new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8465), new Guid("a54c9e4b-aca5-443d-a282-744a0ae7f883") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8468), new DateTime(2023, 9, 1, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8469), new Guid("787b4fc6-37b0-4c9c-9bd5-88a60a264fcd") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8473), new DateTime(2023, 8, 27, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8474), new Guid("9ae7a368-50f1-4f2b-8afb-f0a277a6cd1c") });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateRequested", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8476), new DateTime(2023, 8, 22, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8477), new Guid("101870f1-2fd4-40e5-aa3c-cf5c63eeab8a") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(7514), new Guid("123a207f-89eb-485d-8c42-6fdb55257071") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(7516), new Guid("2e3d4fbb-78ad-441b-993e-9e41858fb8f1") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(7518), new Guid("3a5dd7c0-50d4-4922-8632-9c896b93fa54") });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(7519), new Guid("6f015dab-7e78-4721-8e19-53f04c49876a") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(7622), new Guid("a31dc407-7f8c-4120-9f5a-5bb0dd96acae") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(7624), new Guid("07e3e1df-edf7-4d70-bd21-b0fcbb31be1d") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8377), new Guid("d81dc291-e13c-4a80-88e8-5edac4f7dea5") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateCreated", "RowId" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 40, 41, 640, DateTimeKind.Local).AddTicks(8382), new Guid("c980cae9-c64d-4a26-9342-664dada22fbb") });
        }
    }
}
