using BusinessComponent;

namespace CA_ApplicationLayer;

public class GetBeerUseCase(IRepository beerRepository)
{
    private readonly IRepository _beerRepository = beerRepository;

    public async Task<IEnumerable<Beer>> ExecuteAsync()
    {
        return await _beerRepository.GetAllAsync();
    }
}