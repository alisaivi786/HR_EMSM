
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
    public async Task<APIResponse<T>> Add(T entity)
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