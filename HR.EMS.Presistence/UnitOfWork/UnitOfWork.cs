
using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Presistence.Repositories;

namespace HR.EMS.Presistence.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly HrDatabaseContext _context;
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ApplicationSettings _applicationSettings;

    public UnitOfWork(HrDatabaseContext context,IConfiguration configuration,IHttpContextAccessor httpContextAccessor,ApplicationSettings applicationSettings)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
        _applicationSettings = applicationSettings;
        _configuration = configuration;
        
        AuthRepository = new AuthRepository(_context,_configuration, _httpContextAccessor,_applicationSettings);
        ApiLogRepository = new ApiLogRepository(_context,_configuration, _httpContextAccessor,_applicationSettings);
        //LeaveAllocationRepository = new LeaveAllocationRepository(_context, _configuration, _httpContextAccessor, _applicationSettings);
        //LeaveNatureRepository = new LeaveNatureRepository(_context, _configuration, _httpContextAccessor, _applicationSettings);
        LeaveRequestRepository = new LeaveRequestRepository(_context, _configuration, _httpContextAccessor, _applicationSettings);
        //LeaveTypeRepository = new LeaveTypeRepository(_context, _configuration, _httpContextAccessor, _applicationSettings);
        //RoleRepository = new RoleRepository_context,_configuration, _httpContextAccessor,_applicationSettings);
        //UserRepository = new UserRepository(_context, _configuration, _httpContextAccessor, _applicationSettings);
    }

    public IAuthRepository AuthRepository { get; }
    //public ILeaveAllocationRepository LeaveAllocationRepository { get; }
    //public ILeaveNatureRepository LeaveNatureRepository { get; }
    public ILeaveRequestRepository LeaveRequestRepository { get; }

    public IApiLogRepository ApiLogRepository { get; }

    //public ILeaveTypeRepository LeaveTypeRepository { get; }
    //public IRoleRepository RoleRepository { get; }
    //public IUserRepository UserRepository { get; }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();


    }
}

