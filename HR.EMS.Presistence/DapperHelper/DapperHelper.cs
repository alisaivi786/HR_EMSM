using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Presistence.DapperHelper;

public static class DapperHelper
{
    private static readonly string connectionString = new ApplicationSettings().ConnectionString.SqlConnection;

    public static APIResponse<IEnumerable<T>> ExecuteStoredProcedure<T>(string storedProcedureName, T model)
    {
        using IDbConnection dbConnection = new SqlConnection(connectionString);
        dbConnection.Open();
        var parameters = new DynamicParameters();

        // Map model properties to stored procedure parameters
        foreach (var property in model.GetType().GetProperties())
        {
            var propertyName = property.Name;
            var propertyValue = property.GetValue(model);
            parameters.Add($"@{propertyName}", propertyValue);
        }

        // Execute the stored procedure
        var result = dbConnection.Query<T>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
        if (result != null)
        {
            return new APIResponse<IEnumerable<T>>() { Data = result, Message = Constants.DataInserted };
        }
        return new APIResponse<IEnumerable<T>>() { Success = false, Message = "Insert data failed!" };
    }
}

