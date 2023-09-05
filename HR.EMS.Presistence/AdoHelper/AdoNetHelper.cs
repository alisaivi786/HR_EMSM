using HR.EMS.Application.StaticHelpers;
using Microsoft.Data.SqlClient;
using System.Data;

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

    public static APIResponse<bool> InsertQuery<T>(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }


        try
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand command = connection.CreateCommand();
            var tableName = typeof(T).Name; // Use the name of the type as the table name (assuming the table name matches the type name)

            // Generate SQL query based on properties of the log object
            var sqlQuery = $@"
                    INSERT INTO {tableName} ({StaticHelpers.GetColumnNames(entity)})
                    VALUES ({StaticHelpers.GetParameterNames(entity)})";

            command.CommandText = sqlQuery;

            // Create parameters for each property
            foreach (var property in typeof(T).GetProperties())
            {

                // Check if the property is marked with the [ExcludeParameter] attribute
                if (Attribute.IsDefined(property, typeof(ExcludeParameterAttribute)))
                {
                    continue; // Skip this property
                }

                var paramName = $"@{property.Name}";
                var paramValue = property.GetValue(entity) ?? DBNull.Value;

                command.Parameters.Add(new SqlParameter(paramName, paramValue));
            }

            int rowsAffected = command.ExecuteNonQuery();
            return new APIResponse<bool>() { Data = true, Message = Constants.DataInserted };
        }
        catch (Exception ex)
        {
            return new APIResponse<bool>() { Data = true, Message = ex.Message, Success = false };
        }
    }

    
}