USE [HR_EMS]
GO
/****** Object:  StoredProcedure [dbo].[InsertLeaveRequest]    Script Date: 06/09/2023 7:09:58 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[InsertLeaveRequest]
    @StartDate datetime2,
    @EndDate datetime2,
    @LeaveTypeId bigint,
    @DateRequested datetime2,
    @RequestComments nvarchar(max),
    @Approved bit,
    @Cancelled bit,
    @EmployeeId bigint,
    @RowId uniqueidentifier,
    @DateCreated datetime2,
    @CreatedBy bigint,
    @DateModified datetime2,
    @ModifiedBy bigint,
    @DateDeleted datetime2,
    @DeletedBy bigint,
    @IsActive bit,
    @IsDeleted bit
AS
BEGIN
    INSERT INTO LeaveRequests (
        StartDate, 
        EndDate, 
        LeaveTypeId, 
        DateRequested, 
        RequestComments, 
        Approved, 
        Cancelled, 
        EmployeeId, 
        RowId, 
        DateCreated, 
        CreatedBy, 
        DateModified, 
        ModifiedBy, 
        DateDeleted, 
        DeletedBy, 
        IsActive, 
        IsDeleted
    )
    VALUES (
        @StartDate, 
        @EndDate, 
        @LeaveTypeId, 
        @DateRequested, 
        @RequestComments, 
        @Approved, 
        @Cancelled, 
        @EmployeeId, 
        @RowId, 
        @DateCreated, 
        @CreatedBy, 
        @DateModified, 
        @ModifiedBy, 
        @DateDeleted, 
        @DeletedBy, 
        @IsActive, 
        @IsDeleted
    )
END
