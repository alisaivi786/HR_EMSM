
using HR.EMS.Common.DTOs.LeaveDTO;

namespace HR.EMS.Presistence.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    public LeaveRequestRepository(HrDatabaseContext context, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, ApplicationSettings applicationSettings) : base(context, configuration, httpContextAccessor, applicationSettings)
    {
    }

    public async Task<APIResponse<LeaveResponseDTO>> AddAsync(LeaveRequestDTO leaveRequest)
    {
        try
        {
            var entity = new LeaveRequest
            {
                // Initialize user properties
                StartDate = leaveRequest.StartDate,
                EndDate = leaveRequest.EndDate,
                Approved = false,//leaveRequest.Approved,
                Cancelled = false,//leaveRequest.Cancelled,
                RequestComments = leaveRequest.RequestComments,
                DateRequested = DateTime.Now,
                LeaveTypeId = leaveRequest.LeaveTypeId,
                EmployeeId = leaveRequest.RequestingEmployeeId,
                CreatedBy = leaveRequest.RequestingEmployeeId,
                //EmployeeId = leaveRequest.RequestingEmployeeId
            };

            //var result = await SaveLeaveRequestAsync(entity);
            //var addedEntity = await AddAsync(entity);
            //var addedEntity = DapperHelper.DapperHelper.ExecuteStoredProcedure<LeaveRequest>("InsertLeaveRequest", entity);
            //var addedEntity = AdoHelper.AdoNetHelper.ExecuteStoredProcedure("InsertLeaveRequest", entity);
            var addedEntity = AdoHelper.AdoNetHelper.ExecuteStoredProcedure<LeaveRequest>("InsertLeaveRequest", entity);

            if (addedEntity.Success)
            {
                // TODO: Populate RegisterResponseDTO
                var response = new LeaveResponseDTO
                {
                    Approved = false,
                    Cancelled = false,
                    StartDate = leaveRequest.StartDate,
                    EndDate = leaveRequest.EndDate,
                    DateRequested = DateTime.Now,
                    RequestComments = leaveRequest.RequestComments,
                    LeaveTypeId = leaveRequest.LeaveTypeId,// Need Code Factor
                    Employee = "ALI"
                };
                return new APIResponse<LeaveResponseDTO>
                {
                    Success = true,
                    Message = Constants.RegistrationSuccessful,
                    Data = response
                };
            }
            else
            {
                return new APIResponse<LeaveResponseDTO>
                {
                    Success = false,
                    Message = Constants.ErrorDuringRegistration
                };
            }
        }
        catch (DbException dbEx)
        {
            // Handle database connection exceptions
            return new APIResponse<LeaveResponseDTO>
            {
                Success = false,
                Message = Constants.ErrorDuringRegistration,
                Error = new List<Error>
            {
                new Error
                {
                    Id = Guid.NewGuid().ToString(),
                    Message = "Database connection error: " + dbEx.Message
                }
            }
            };
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            return new APIResponse<LeaveResponseDTO>
            {
                Success = false,
                Message = Constants.ErrorDuringRegistration,
                Error = new List<Error>
            {
                new Error
                {
                    Id = Guid.NewGuid().ToString(),
                    Message = "An error occurred during registration: " + ex.Message
                }
            }
            };
        }
    }

    public  async Task<APIResponse<DashboardDTO>> DashBoardAsync(int EmployeeID)
    {
        var data = await DashboardData(EmployeeID);

        return new APIResponse<DashboardDTO>() { Data = data,Message = Constants.DataFetched};
    }

    public async Task<APIResponse<LeaveDeleteDTO>> DeleteAsync(LeaveDeleteDTO deleteDTO)
    {
        try
        {
            var ExisitData = Table.FirstOrDefault(x=>x.Id == Convert.ToInt64(deleteDTO.LeaveId));
            // Map the IQueryable of leaves to an IQueryable of DTOs
            ExisitData.IsDeleted = true;
            ExisitData.IsActive = false;


            var res = await Update(ExisitData);

            return await Task.FromResult(new APIResponse<LeaveDeleteDTO>
            {
                Success = true,
                Data = deleteDTO,
                Message = "Leaves Deleted successfully."
            });
        }
        catch (Exception ex)
        {
            return await Task.FromResult(new APIResponse<LeaveDeleteDTO>
            {
                Success = false,
                Data = null,
                Message = $"Error: {ex.Message}"
            });
        }
    }

    public async Task<APIResponse<List<LeaveResponseDTO>>> GetAllAsync()
    {
        try
        {
            // Get the leaves as an IQueryable
            var leaves = GetAll();

            // Map the IQueryable of leaves to an IQueryable of DTOs
            var leaveDTOs = leaves.Where(x=>x.IsActive == true).Select(x => new LeaveResponseDTO
            {
                Approved = x.Approved,
                Cancelled = x.Cancelled,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                DateRequested = x.DateRequested,
                RequestComments = x.RequestComments,
                LeaveId = x.Id,

                // Map other properties as needed
            }).ToList();

            return await Task.FromResult(new APIResponse<List<LeaveResponseDTO>>
            {
                Success = true,
                Data = leaveDTOs,
                Message = "Leaves retrieved successfully."
            });
        }
        catch (Exception ex)
        {
            return await Task.FromResult(new APIResponse<List<LeaveResponseDTO>>
            {
                Success = false,
                Data = null,
                Message = $"Error: {ex.Message}"
            });
        }
    }

}
