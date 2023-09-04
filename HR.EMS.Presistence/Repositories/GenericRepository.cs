
using HR.EMS.Application.Configurations;
using HR.EMS.Common.DTOs.LeaveDTO;
using HR.EMS.Domain;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EpicLoanSystem.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class

{
    protected readonly DbContext _context;
    protected readonly IConfiguration _configuration;
    protected readonly IHttpContextAccessor _httpContextAccessor;
    protected readonly ApplicationSettings _applicationSettings;

    protected readonly string _myIP = string.Empty;
    protected readonly string _macAddress = string.Empty;
    public DbSet<T> Table { get; set; }
    public GenericRepository(HrDatabaseContext context, IConfiguration configuration,IHttpContextAccessor httpContextAccessor, ApplicationSettings applicationSettings)
    {

        _context = context;
        _httpContextAccessor = httpContextAccessor;
        _applicationSettings = applicationSettings;
        _configuration = configuration;

        Table = context.Set<T>();
       
    }
    public async Task<APIResponse<T>> AddAsync(T entity)
    {
        var e = Table.Add(entity);
        await _context.SaveChangesAsync();
        return new APIResponse<T> { Data = e.Entity ,Message = Constants.DataInserted};
    }


    public async Task<APIResponse<List<T>>> AddMultiple(IEnumerable<T> entities)
    {
        Table.AddRange(entities);
        await _context.SaveChangesAsync();
        var response = new APIResponse<List<T>>
        {
            Data = entities.ToList(),
            Message = Constants.DataInserted
        };
        return response;
    }

    public async Task<APIResponse<T>> Delete(int id, int userId)
    {
        var entity = await GetById(id);
        return await Update(entity);
    }


    public bool DeletePermanently(T entity)
    {
        Table.Remove(entity);
        return Save();
    }

    public IQueryable<T> GetAll()
    {
        return Table;
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate);
    }

   
    public async Task<T> GetAvailable(int Id)
    {
        return await Table.FindAsync(Id);
    }

    public async Task<T> GetById(int id)
    {
        return await GetAvailable(id);
    }
    public async Task<APIResponse<List<T>>> RemoveRange(IEnumerable<T> entities)
    {
        Table.RemoveRange(entities);
        await _context.SaveChangesAsync();
        var response = new APIResponse<List<T>>
        {
            Data = entities.ToList(),
            Message = Constants.DataDeleted

        };
        return response;
    }

    public async Task<APIResponse<T>> Update(T entity)
    {
        _ = Table.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return new APIResponse<T> { Data = entity, Message = Constants.DataUpdated };
    }

    public async Task<APIResponse<List<T>>> UpdateMultiple(IEnumerable<T> entities)
    {
        _ = Table;
        Table.UpdateRange(entities);
        await _context.SaveChangesAsync();
        var response = new APIResponse<List<T>>
        {
            Data = entities.ToList(),
            Message = Constants.DataUpdated
        };
        return response;
    }
    // Define a method to save a LeaveRequest using a stored procedure
    public async Task<int> SaveLeaveRequestAsync(LeaveRequest leaveRequest)
    {
        //using var connection = new SqlConnection(_applicationSettings.ConnectionString.SqlConnection);
       // await connection.OpenAsync();
        int newLeaveRequestId = 0;

        using (SqlConnection connection = new SqlConnection(_applicationSettings.ConnectionString.SqlConnection))
        {
            using (SqlCommand command = new SqlCommand("SP_LeaveRequest_ADD", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StartDate", leaveRequest.StartDate);
                command.Parameters.AddWithValue("@EndDate", leaveRequest.EndDate);
                command.Parameters.AddWithValue("@LeaveTypeId", leaveRequest.LeaveTypeId);
                command.Parameters.AddWithValue("@DateRequested", leaveRequest.DateRequested);
                command.Parameters.AddWithValue("@RequestComments", leaveRequest.RequestComments);
                command.Parameters.AddWithValue("@Approved", leaveRequest.Approved);
                command.Parameters.AddWithValue("@Cancelled", leaveRequest.Cancelled);
                command.Parameters.AddWithValue("@EmployeeId", leaveRequest.EmployeeId);
                command.Parameters.AddWithValue("@RequestingEmployeeId", leaveRequest.EmployeeId);
                command.Parameters.AddWithValue("@RowId", leaveRequest.RowId);
                command.Parameters.AddWithValue("@DateCreated", leaveRequest.DateCreated);
                command.Parameters.AddWithValue("@CreatedBy", leaveRequest.CreatedBy);
                command.Parameters.AddWithValue("@DateModified", leaveRequest.DateModified);
                command.Parameters.AddWithValue("@ModifiedBy", leaveRequest.ModifiedBy);
                command.Parameters.AddWithValue("@DateDeleted", leaveRequest.DateDeleted);
                command.Parameters.AddWithValue("@DeletedBy", leaveRequest.DeletedBy);
                command.Parameters.AddWithValue("@IsActive", leaveRequest.IsActive);
                command.Parameters.AddWithValue("@IsDeleted", leaveRequest.IsDeleted);

                SqlParameter outputParameter = new SqlParameter("@NewLeaveRequestId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParameter);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                if (outputParameter.Value != DBNull.Value)
                {
                    newLeaveRequestId = (int)outputParameter.Value;
                }
            }
        }

        return newLeaveRequestId;
    }

    public async Task<DashboardDTO> DashboardData(int EmployeeId)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(_applicationSettings.ConnectionString.SqlConnection))
            {
                using (SqlCommand command = new SqlCommand("CalculateLeaveSummaryByEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the stored procedure
                    command.Parameters.AddWithValue("@EmployeeId", EmployeeId);

                    await connection.OpenAsync();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalCanceled = (int)reader["TotalRejectLeave"];
                            int totalPending = (int)reader["TotalPendingLeave"];
                            int totalApproved = (int)reader["TotalAvailedLeave"];
                            int TotalEmployeeLeave = (int)reader["TotalEmployeeLeave"];

                            return new DashboardDTO() { Pending = totalPending.ToString(), Approved = totalApproved.ToString(), Reject = totalCanceled.ToString() , TotalEmployeeLeave  = TotalEmployeeLeave.ToString()};
                        }
                        else
                        {

                        }
                    }
                }
            }
        }
        catch (Exception)
        {
            return new DashboardDTO() { Pending = "0", Approved = "0", Reject = "0", TotalEmployeeLeave = "0" };
        }
        
        return new DashboardDTO() { Pending = "0", Approved = "0", Reject = "0", TotalEmployeeLeave  = "0"};
    }

    private bool Save()
    {
        try
        {
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}