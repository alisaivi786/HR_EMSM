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
    [Migration("20230904060048_RemoveLeaveAllocationColumns")]
    partial class RemoveLeaveAllocationColumns
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

                    b.Property<string>("ResponseHeaders")
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(445),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Travel",
                            RowId = new Guid("bfe98761-a0ed-4c8e-abca-f6da189e92c9")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(457),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Local",
                            RowId = new Guid("aba7f444-f97f-4bf7-9821-99e6d5581516")
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1799),
                            DateRequested = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1805),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Vacation leave",
                            RowId = new Guid("a0c9e329-8662-45b9-93b3-095bc5f95ab3"),
                            StartDate = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Approved = false,
                            Cancelled = true,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1809),
                            DateRequested = new DateTime(2023, 8, 30, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1810),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RequestComments = "Sick leave",
                            RowId = new Guid("421d8978-f242-4f91-98e2-30ae994f5734"),
                            StartDate = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1816),
                            DateRequested = new DateTime(2023, 8, 25, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1818),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RequestComments = "Study leave",
                            RowId = new Guid("5c68e68a-bd29-4817-87c2-abb187e82097"),
                            StartDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1821),
                            DateRequested = new DateTime(2023, 8, 20, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1823),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Holiday leave",
                            RowId = new Guid("019d2315-f4a0-4cf2-bf4e-d868855853d0"),
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(630),
                            DefaultDays = 10,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Sick Leave",
                            RowId = new Guid("e524d735-9843-485f-b5fd-988fdd1facd6")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(633),
                            DefaultDays = 20,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Annual Leave",
                            RowId = new Guid("8b404eba-7976-40c6-9916-5ab56dd9f295")
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(636),
                            DefaultDays = 15,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Study Leave",
                            RowId = new Guid("08ea2de3-19ac-4519-abdf-aebbc21471f3")
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(638),
                            DefaultDays = 90,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Maternal Leave",
                            RowId = new Guid("b21cf7ea-2555-42c1-8757-92a99d16810a")
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(730),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "admin",
                            RowId = new Guid("508da4e1-201c-4ef4-8a57-4a7bba5ecbf1")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(753),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "employee",
                            RowId = new Guid("1805ff84-1384-47ac-8e9c-a03a2b4a4c5f")
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1691),
                            Email = "ali.mushtaq@example.com",
                            FirstName = "Ali",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 1L,
                            RowId = new Guid("6e5fd214-8147-4c2a-80ae-f196081c80cd"),
                            UserName = "alimushtaq"
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 0, 48, 115, DateTimeKind.Local).AddTicks(1696),
                            Email = "junaid.mushtaq@example.com",
                            FirstName = "Junaid",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 2L,
                            RowId = new Guid("3e60f9f3-c7d5-4d53-82d4-71e6e3f09aa4"),
                            UserName = "junaidmushtaq"
                        });
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