import { Dashboard } from "./dashboard.model";

export interface DashboardResponse {
    data: Dashboard;
    success: boolean;
    message: string;
    error: null | string;
  }