export interface AuthResponse {
  data: {
    token: string;
  };
  success: boolean;
  message: string;
  error: any | null;
}