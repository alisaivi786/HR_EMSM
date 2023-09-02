using HR.EMS.Common.DTOs.LeaveDTO;
using HR.EMS.Common.Response;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HR.EMS.Application.Contracts.Presistence;

public interface IGenericRepository<T> where T : class
{
    DbSet<T> Table { get; }
    Task<APIResponse<T>> AddAsync(T entity);
    Task<APIResponse<T>> Update(T entity);
    Task<APIResponse<T>> Delete(int id, int userId);
    Task<APIResponse<List<T>>> AddMultiple(IEnumerable<T> entities);
    Task<APIResponse<List<T>>> UpdateMultiple(IEnumerable<T> entities);
    Task<APIResponse<List<T>>> RemoveRange(IEnumerable<T> entities);
    bool DeletePermanently(T entity);
    Task<T> GetById(int id);
    IQueryable<T> GetAll();
    IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
    Task<T> GetAvailable(int Id);
    Task<DashboardDTO> DashboardData(int EmployeeId);
}
