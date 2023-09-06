USE [HR_EMS]
GO
/****** Object:  StoredProcedure [dbo].[CalculateLeaveSummaryByEmployee]    Script Date: 06/09/2023 7:17:43 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[CalculateLeaveSummaryByEmployee234]
    @EmployeeId bigint
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TotalAvailedLeave INT;
    DECLARE @TotalRejectLeave INT;
    DECLARE @TotalPendingLeave INT;
	DECLARE @TotalEmployeeLeave INT;

    -- Calculate Total Availed Leave (Approved = 1)
    SELECT @TotalAvailedLeave = COUNT(*)
    FROM LeaveRequests
    WHERE Approved = 1 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;

    -- Calculate Total Reject Leave (Cancelled = 1)
    SELECT @TotalRejectLeave = COUNT(*)
    FROM LeaveRequests
    WHERE Cancelled = 1 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;

    -- Calculate Total Pending Leave (Approved = 0 AND Cancelled = 0)
    SELECT @TotalPendingLeave = COUNT(*)
    FROM LeaveRequests
    WHERE Approved = 0 AND Cancelled = 0 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;

	-- Calculate Total Employee Leave
	SELECT @TotalEmployeeLeave = SUM(DefaultDays)
	FROM (
		SELECT al.EmployeeId, lt.DefaultDays
		FROM LeaveAllocations al
		INNER JOIN LeaveTypes lt ON al.LeaveTypeId = lt.Id
	) AS tbl
	WHERE EmployeeId = 1 
	GROUP BY EmployeeId;

    -- Return the results
    SELECT
        TotalAvailedLeave = @TotalAvailedLeave,
        TotalRejectLeave = @TotalRejectLeave,
        TotalPendingLeave = @TotalPendingLeave,
		TotalEmployeeLeave = @TotalEmployeeLeave;

END;
