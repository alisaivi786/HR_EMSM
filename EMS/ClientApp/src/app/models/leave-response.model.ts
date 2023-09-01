import { LeaveData } from "./leave-data.model";

export interface LeaveResponse {
    data: LeaveData[];
    success: boolean;
    message: string;
    error: null | string;
  }