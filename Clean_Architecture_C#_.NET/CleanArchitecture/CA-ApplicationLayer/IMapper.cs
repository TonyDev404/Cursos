namespace CA_ApplicationLayer;

public interface IMapper<TDTO, TOutput>
{
    public TOutput ToEntity(TDTO dto);
}