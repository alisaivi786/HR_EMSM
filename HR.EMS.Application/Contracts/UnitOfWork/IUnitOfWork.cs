/*
 * Author: ALI RAZA MUSHTAQ
 * Email: alisaivi786@gmail.com
 */

namespace HR.EMS.Application.Contracts.UnitOfWork;

/// <summary>
/// Represents a unit of work for managing repositories and saving changes.
/// </summary>
public interface IUnitOfWork : IDisposable
{
    // Repositories
    IAuthRepository AuthRepository { get; }
    //ILeaveAllocationRepository LeaveAllocationRepository { get; }
    //ILeaveNatureRepository LeaveNatureRepository { get; }
    ILeaveRequestRepository LeaveRequestRepository { get; }
    //ILeaveTypeRepository LeaveTypeRepository { get; }
    //IRoleRepository RoleRepository { get; }
    //IUserRepository UserRepository { get; }

    IApiLogRepository ApiLogRepository { get; }

    /// <summary>
    /// Asynchronously saves changes to the underlying database.
    /// </summary>
    /// <returns>A task representing the asynchronous save operation.</returns>
    Task SaveAsync();

    /// <summary>
    /// Asynchronously saves changes to the underlying database and returns the number of objects saved.
    /// </summary>
    /// <returns>A task representing the asynchronous save operation and the number of objects saved.</returns>
    Task<int> SaveChangesAsync();
}
