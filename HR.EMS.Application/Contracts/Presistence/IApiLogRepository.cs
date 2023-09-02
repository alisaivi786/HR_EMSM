using HR.EMS.Common.DTOs.LogsDTO;
using HR.EMS.Common.Response;
using HR.EMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Application.Contracts.Presistence
{
    public interface IApiLogRepository : IGenericRepository<ApiLogs>
    {
        Task<APIResponse<bool>> AddLogsAsync(AddApiLogsDTO request);
        Task<APIResponse<DetailsApiLogDTO>> GetAllLogsAsync();
        
    }
}
