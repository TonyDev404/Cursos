using CA_EnterpriseLayer;

namespace CA_ApplicationLayer;

public interface IRepository<T>
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(Beer beer);
}