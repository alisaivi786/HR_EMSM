﻿// <auto-generated />
using System;
using HR.EMS.Presistence.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    [DbContext(typeof(HrDatabaseContext))]
    [Migration("20230906033942_CreateStoredProcedure2")]
    partial class CreateStoredProcedure2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HR.EMS.Domain.ApiLogs", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<int?>("ElapsedMilliseconds")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("RequestBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestHeaders")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponseBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResponseTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ApiLogs");
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveAllocations", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("LeaveTypeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveAllocations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6007),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RowId = new Guid("f08bf6bc-3881-4a76-b144-f8480150901f")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6009),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RowId = new Guid("c70d315a-d3f0-43a8-8def-97b7d1f2c529")
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6012),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RowId = new Guid("342ca087-78c2-4082-a844-acfc5385d6d2")
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6013),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RowId = new Guid("1c317f20-2312-45fe-8ab1-09dff00a779b")
                        },
                        new
                        {
                            Id = 5L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6015),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RowId = new Guid("59e1ee54-9241-41f1-8ba9-9d06c8059d7d")
                        },
                        new
                        {
                            Id = 6L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6016),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RowId = new Guid("5ddb8a4a-acbf-4f83-9f47-7b68af818662")
                        },
                        new
                        {
                            Id = 7L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(6017),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 4L,
                            RowId = new Guid("9ee11b81-e84f-42ba-9a8f-ebfd66e28f4e")
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveNatures", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LeaveNatures");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(4893),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Travel",
                            RowId = new Guid("901e3621-0ba7-45d7-8d29-8b88c3db2780")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(4914),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Local",
                            RowId = new Guid("bba7a52d-c6fa-4eaf-b2d2-d56edcffb03e")
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool?>("Approved")
                        .HasColumnType("bit");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("bit");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("LeaveTypeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("RequestComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveRequests");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5911),
                            DateRequested = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5915),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Vacation leave",
                            RowId = new Guid("2b2cbaa9-71a8-453f-befa-c8bcc0d4b22e"),
                            StartDate = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Approved = false,
                            Cancelled = true,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5917),
                            DateRequested = new DateTime(2023, 9, 1, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5918),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RequestComments = "Sick leave",
                            RowId = new Guid("ad36afc3-56cc-4689-8006-f432c1556d5e"),
                            StartDate = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5928),
                            DateRequested = new DateTime(2023, 8, 27, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5930),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RequestComments = "Study leave",
                            RowId = new Guid("a18b86cb-3541-4732-940f-acf2eea0a055"),
                            StartDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5931),
                            DateRequested = new DateTime(2023, 8, 22, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5933),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Holiday leave",
                            RowId = new Guid("ee0a6d08-ee98-4169-9f60-e0c531818792"),
                            StartDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefaultDays")
                        .HasColumnType("int");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5031),
                            DefaultDays = 10,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Sick Leave",
                            RowId = new Guid("6f274874-9574-4bd8-848e-0ec4bf4e6c77")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5033),
                            DefaultDays = 20,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Annual Leave",
                            RowId = new Guid("d693b8f5-dd57-451b-92a8-5734b93e3d16")
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5035),
                            DefaultDays = 15,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Study Leave",
                            RowId = new Guid("59713578-5695-49a7-ad02-1e3aa0a52db6")
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5036),
                            DefaultDays = 90,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Maternal Leave",
                            RowId = new Guid("416997b2-4672-4327-b5a4-4d660e069ab0")
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.Roles", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5103),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "admin",
                            RowId = new Guid("19e73d8c-9a41-4c7f-bac2-4df69afe0b52")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5105),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "employee",
                            RowId = new Guid("5b0797e3-95d7-4736-b35c-e59c3bf45f93")
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("GenderId")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5820),
                            Email = "ali.mushtaq@example.com",
                            FirstName = "Ali",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 1L,
                            RowId = new Guid("aacc6181-1db3-45c3-a456-51ad6c497a97"),
                            UserName = "alimushtaq"
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 39, 42, 580, DateTimeKind.Local).AddTicks(5824),
                            Email = "junaid.mushtaq@example.com",
                            FirstName = "Junaid",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 2L,
                            RowId = new Guid("2e5afa0d-162e-4fca-aa0b-283ea1504aec"),
                            UserName = "junaidmushtaq"
                        });
                });

            modelBuilder.Entity("object", b =>
                {
                    b.ToTable((string)null);

                    b.ToSqlQuery("EXEC sp_executesql N'USE [HR_EMS]\r\nGO\r\n/****** Object:  StoredProcedure [dbo].[CalculateLeaveSummaryByEmployee]    Script Date: 06/09/2023 7:17:43 am ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\nALTER PROCEDURE [dbo].[CalculateLeaveSummaryByEmployee]\r\n    @EmployeeId bigint\r\nAS\r\nBEGIN\r\n    SET NOCOUNT ON;\r\n\r\n    DECLARE @TotalAvailedLeave INT;\r\n    DECLARE @TotalRejectLeave INT;\r\n    DECLARE @TotalPendingLeave INT;\r\n	DECLARE @TotalEmployeeLeave INT;\r\n\r\n    -- Calculate Total Availed Leave (Approved = 1)\r\n    SELECT @TotalAvailedLeave = COUNT(*)\r\n    FROM LeaveRequests\r\n    WHERE Approved = 1 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;\r\n\r\n    -- Calculate Total Reject Leave (Cancelled = 1)\r\n    SELECT @TotalRejectLeave = COUNT(*)\r\n    FROM LeaveRequests\r\n    WHERE Cancelled = 1 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;\r\n\r\n    -- Calculate Total Pending Leave (Approved = 0 AND Cancelled = 0)\r\n    SELECT @TotalPendingLeave = COUNT(*)\r\n    FROM LeaveRequests\r\n    WHERE Approved = 0 AND Cancelled = 0 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;\r\n\r\n	-- Calculate Total Employee Leave\r\n	SELECT @TotalEmployeeLeave = SUM(DefaultDays)\r\n	FROM (\r\n		SELECT al.EmployeeId, lt.DefaultDays\r\n		FROM LeaveAllocations al\r\n		INNER JOIN LeaveTypes lt ON al.LeaveTypeId = lt.Id\r\n	) AS tbl\r\n	WHERE EmployeeId = 1 \r\n	GROUP BY EmployeeId;\r\n\r\n    -- Return the results\r\n    SELECT\r\n        TotalAvailedLeave = @TotalAvailedLeave,\r\n        TotalRejectLeave = @TotalRejectLeave,\r\n        TotalPendingLeave = @TotalPendingLeave,\r\n		TotalEmployeeLeave = @TotalEmployeeLeave;\r\n\r\nEND;\r\n'");
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveAllocations", b =>
                {
                    b.HasOne("HR.EMS.Domain.Users", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.EMS.Domain.LeaveTypes", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveRequest", b =>
                {
                    b.HasOne("HR.EMS.Domain.Users", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.EMS.Domain.LeaveTypes", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("HR.EMS.Domain.Users", b =>
                {
                    b.HasOne("HR.EMS.Domain.Roles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
