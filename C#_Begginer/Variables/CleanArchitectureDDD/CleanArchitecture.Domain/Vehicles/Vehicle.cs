using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehicles;

public sealed class Vehicle : Entity

{
    public Vehicle(
        Guid id,
        Model model,
        Vin vin,
        Money price,
        Money maintenance,
        DateTime? lastDateRent,
        List<Accessory> accessories,
        Direction direction)
        : base(id)
    {
        Model = model;
        Vin = vin;
        Price = price;
        Maintenance = maintenance;
        LastDateRent = lastDateRent;
        Accessories = accessories;
        Direction = direction;
    }

    public Model? Model { get; private set; } //Solo a nivel de esta clase es posible modificar el valor de la prop
    public Vin? Vin { get; private set; }
    public Direction? Direction { get; private set; }
    public Money? Price { get; private set; }
    public Money? Maintenance { get; private set; }
    public DateTime? LastDateRent { get; private set; }

    public List<Accessory> Accessories { get; private set; } = [];
}