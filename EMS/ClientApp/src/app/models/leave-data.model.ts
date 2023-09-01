export interface LeaveData {
    startDate: string;
    endDate: string;
    leaveType: string | null;
    dateRequested: string;
    requestComments: string;
    approved: boolean;
    cancelled: boolean;
    employee: string | null;
    leaveId: number;
  }