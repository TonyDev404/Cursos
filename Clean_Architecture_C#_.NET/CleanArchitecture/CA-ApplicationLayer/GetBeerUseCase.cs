using CA_EnterpriseLayer;

namespace CA_ApplicationLayer;

public class GetBeerUseCase<TEntity, TOutput>(IRepository<TEntity> beerRepository, IPresenter<TEntity, TOutput> presenter)
{
    private readonly IRepository<TEntity> _beerRepository = beerRepository;
    private readonly IPresenter<TEntity, TOutput> _presenter = presenter;

    public async Task<IEnumerable<TOutput>> ExecuteAsync()
    {
        var beers =  await _beerRepository.GetAllAsync();
        return _presenter.Present(beers);
    }
}