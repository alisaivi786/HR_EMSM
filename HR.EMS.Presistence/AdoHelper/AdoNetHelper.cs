using HR.EMS.Application.Configurations;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Presistence.AdoHelper;

public class AdoNetHelper
{
    private static readonly string connectionString = new ApplicationSettings().ConnectionString.SqlConnection;

    public static APIResponse<bool> ExecuteStoredProcedure<T>(string storedProcedureName, T parameterObject)
    {
        try
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand command = new(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            // Get properties of the parameter object using reflection
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                // Check if the property is marked with the [ExcludeParameter] attribute
                if (Attribute.IsDefined(property, typeof(ExcludeParameterAttribute)))
                {
                    continue; // Skip this property
                }

                // Get the parameter value from the parameter object
                var value = property.GetValue(parameterObject);

                // Add the parameter to the command
                command.Parameters.AddWithValue("@" + property.Name, value ?? DBNull.Value);
            }

            // Execute the stored procedure
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            return new APIResponse<bool> { Success = false, Message = ex.Message };
        }

        return new APIResponse<bool> { Data = true, Message = "DataInserted" };
    }
    public static APIResponse<bool> ExecuteStoredProcedure(string storedProcedureName, LeaveRequest leaveRequest)
    {
        try
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                using SqlCommand command = new(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                command.Parameters.Add(new SqlParameter("@StartDate", leaveRequest.StartDate));
                command.Parameters.Add(new SqlParameter("@EndDate", leaveRequest.EndDate));
                command.Parameters.Add(new SqlParameter("@LeaveTypeId", leaveRequest.LeaveTypeId));
                command.Parameters.Add(new SqlParameter("@DateRequested", leaveRequest.DateRequested));
                command.Parameters.Add(new SqlParameter("@RequestComments", leaveRequest.RequestComments));
                command.Parameters.Add(new SqlParameter("@Approved", leaveRequest.Approved));
                command.Parameters.Add(new SqlParameter("@Cancelled", leaveRequest.Cancelled));
                command.Parameters.Add(new SqlParameter("@EmployeeId", leaveRequest.EmployeeId));
                command.Parameters.Add(new SqlParameter("@RequestingEmployeeId", leaveRequest.EmployeeId));
                command.Parameters.Add(new SqlParameter("@RowId", leaveRequest.RowId));
                command.Parameters.Add(new SqlParameter("@DateCreated", leaveRequest.DateCreated));
                command.Parameters.Add(new SqlParameter("@CreatedBy", leaveRequest.CreatedBy));
                if(leaveRequest.DateModified != null)
                {
                    command.Parameters.Add(new SqlParameter("@DateModified", leaveRequest.DateModified));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@DateModified", DBNull.Value));
                }
                if (leaveRequest.ModifiedBy != null)
                {
                    command.Parameters.Add(new SqlParameter("@ModifiedBy", leaveRequest.ModifiedBy));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@ModifiedBy", DBNull.Value));
                }

                if (leaveRequest.DateDeleted != null)
                {
                    command.Parameters.Add(new SqlParameter("@DateDeleted", leaveRequest.DateDeleted));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@DateDeleted", DBNull.Value));
                }
                if (leaveRequest.DeletedBy != null)
                {
                    command.Parameters.Add(new SqlParameter("@DeletedBy", leaveRequest.DeletedBy));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@DeletedBy", DBNull.Value));
                }
                command.Parameters.Add(new SqlParameter("@IsActive", leaveRequest.IsActive));
                command.Parameters.Add(new SqlParameter("@IsDeleted", leaveRequest.IsDeleted));

                // Execute the stored procedure
                command.ExecuteNonQuery();
            }


            return new APIResponse<bool>() { Data = true , Message = Constants.DataInserted };
        }
        catch (Exception ex)
        {

            return new APIResponse<bool>() { Success = false, Message = ex.Message };
        }

        

    }
}