using CA_EnterpriseLayer;

namespace CA_ApplicationLayer;

public class GetBeerUseCase<T>(IRepository<T> beerRepository)
{
    private readonly IRepository<T> _beerRepository = beerRepository;

    public async Task<IEnumerable<T>> ExecuteAsync()
    {
        return await _beerRepository.GetAllAsync();
    }
}