using Azure.Core;
using HR.EMS.Common.DTOs.LogsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Presistence.Repositories
{
    public class ApiLogRepository : GenericRepository<ApiLogs>, IApiLogRepository
    {
        public ApiLogRepository(HrDatabaseContext context, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, ApplicationSettings applicationSettings) : base(context, configuration, httpContextAccessor, applicationSettings)
        {
        }

        public async Task<APIResponse<bool>> AddLogsAsync(AddApiLogsDTO request)
        {
            var entity = new ApiLogs() {
                RequestMethod = request.RequestMethod,
                RequestPath = request.RequestPath,
                RequestHeaders = request.RequestHeaders,
                RequestBody = request.RequestBody,
                StatusCode = request.StatusCode,
                //ResponseHeaders = request.ResponseHeaders,
                ResponseBody = request.ResponseBody,
            };

            var response = await AddAsync(entity);
            if (response.Success)
            {
                return new APIResponse<bool>() { Data = true, Message = Constants.DataInserted };
            }
            return new APIResponse<bool>() { Data = false, Message = "Failed to Insert Record" };

        }

        public Task<APIResponse<DetailsApiLogDTO>> GetAllLogsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
