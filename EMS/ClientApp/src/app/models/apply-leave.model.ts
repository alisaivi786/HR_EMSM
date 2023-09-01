export interface LeaveRequest {
  startDate: Date;
  endDate: Date;
  leaveTypeId: number;
  requestComments: string;
  requestingEmployeeId: number;
  leaveId: number;
}