using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateStoredProcedure23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
