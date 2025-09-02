using DDD_CA.Domain.Abstractoins;

namespace DDD_CA.Domain.Vehicles;

public sealed class Vehicles : Entity
{
    public Vehicles(
        Guid id,
        Model model,
        Vin vin,
        Money price,
        Money maintenance,
        DateTime lastDateRent,
        List<Accessories> accessories,
        Address address
        ) : base(id)
    {
        Model = model;
        Vin = vin;
        Price = price;
        Maintenance = maintenance;
        LastDateRent = lastDateRent;
        Accessories = accessories;
        Address = address;
    }

    public Model? Model { get; private set; } //Los Object Values se crean a partir de que no pueda existir otro registro igual
    public Vin? Vin { get; private set; }
    public Address? Address { get; private set; }
    public Money? Price { get; private set; }
    public Money? Maintenance { get; private set; }
    public DateTime? LastDateRent { get; private set; }

    public List<Accessories> Accessories { get; private set; } = [];
}