namespace CA_InterfaceAdapter_Mapper.Dtos.Requests;

public class BeerRequestDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Style { get; set; }
    public decimal Alcohol { get; set; }
}