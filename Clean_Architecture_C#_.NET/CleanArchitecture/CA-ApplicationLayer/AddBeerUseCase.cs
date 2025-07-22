using CA_EnterpriseLayer;

namespace CA_ApplicationLayer;

public class AddBeerUseCase<TDTO>(IRepository<Beer> beerRepository, IMapper<TDTO, Beer> mapper)
{
    private readonly IRepository<Beer> _beerRepository = beerRepository;
    private readonly IMapper<TDTO, Beer> _mapper = mapper;
    
    public async Task ExecuteAsync(TDTO beerDTO)
    {
        var beer = _mapper.ToEntity(beerDTO);

        if (string.IsNullOrWhiteSpace(beer.Name))
            throw new Exception("El nombre de la cerveza es obligatorio.");
        
        await _beerRepository.AddAsync(beer);
    }
}