using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapter_Mapper.Dtos.Requests;

namespace CA_InterfaceAdapter_Mapper;

public class BeerMapper : IMapper<BeerRequestDto, Beer>
{
    public Beer ToEntity(BeerRequestDto dto)
        => new Beer()
        {
            Id = dto.Id,
            Name = dto.Name,
            Alcohol = dto.Alcohol,
            Style = dto.Style
        };
}