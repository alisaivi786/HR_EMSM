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
    [Migration("20230901032033_adddata")]
    partial class adddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<long>("NumberOfDays")
                        .HasColumnType("bigint");

                    b.Property<long>("Period")
                        .HasColumnType("bigint");

                    b.Property<Guid>("RowId")
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

                    b.Property<Guid>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LeaveNatures");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Travel",
                            RowId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Local",
                            RowId = new Guid("00000000-0000-0000-0000-000000000000")
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

                    b.Property<long?>("EmployeeId")
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

                    b.Property<long>("RequestingEmployeeId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("RowId")
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
                            DateRequested = new DateTime(2023, 9, 1, 7, 20, 33, 395, DateTimeKind.Local).AddTicks(3083),
                            EndDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Vacation leave",
                            RequestingEmployeeId = 1L,
                            RowId = new Guid("00000000-0000-0000-0000-000000000000"),
                            StartDate = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Approved = false,
                            Cancelled = true,
                            DateRequested = new DateTime(2023, 8, 27, 7, 20, 33, 395, DateTimeKind.Local).AddTicks(3093),
                            EndDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RequestComments = "Sick leave",
                            RequestingEmployeeId = 1L,
                            RowId = new Guid("00000000-0000-0000-0000-000000000000"),
                            StartDate = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Approved = true,
                            Cancelled = false,
                            DateRequested = new DateTime(2023, 8, 22, 7, 20, 33, 395, DateTimeKind.Local).AddTicks(3100),
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RequestComments = "Study leave",
                            RequestingEmployeeId = 1L,
                            RowId = new Guid("00000000-0000-0000-0000-000000000000"),
                            StartDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Approved = true,
                            Cancelled = false,
                            DateRequested = new DateTime(2023, 8, 17, 7, 20, 33, 395, DateTimeKind.Local).AddTicks(3102),
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Holiday leave",
                            RequestingEmployeeId = 1L,
                            RowId = new Guid("00000000-0000-0000-0000-000000000000"),
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

                    b.Property<Guid>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DefaultDays = 10,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Sick Leave",
                            RowId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 2L,
                            DefaultDays = 20,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Annual Leave",
                            RowId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 3L,
                            DefaultDays = 15,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Study Leave",
                            RowId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 4L,
                            DefaultDays = 90,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Maternal Leave",
                            RowId = new Guid("00000000-0000-0000-0000-000000000000")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Admin",
                            RowId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Employee",
                            RowId = new Guid("00000000-0000-0000-0000-000000000000")
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

                    b.Property<Guid>("RowId")
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
                            Email = "ali.mushtaq@example.com",
                            FirstName = "Ali",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 1L,
                            RowId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserName = "alimushtaq"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "junaid.mushtaq@example.com",
                            FirstName = "Junaid",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 2L,
                            RowId = new Guid("00000000-0000-0000-0000-000000000000"),
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
                        .HasForeignKey("EmployeeId");

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