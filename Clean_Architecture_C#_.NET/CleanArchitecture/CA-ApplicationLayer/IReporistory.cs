namespace CA_ApplicationLayer;

public interface IRepository
{
    Task<Beer> GetBeeryByIAsync(int id);
    Task<IEnumerable<Beer>> GetAllAsync();
    Task AddAsync(Beer beer);
}