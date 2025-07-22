using CA_EnterpriseLayer;

namespace CA_ApplicationLayer;

public interface IPresenter<TEntity, TOutput>
{
    public IEnumerable<TOutput> Present(IEnumerable<TEntity> data);
}