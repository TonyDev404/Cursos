using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehicles;

public sealed class Vehicle : Entity
{
    public Vehicle(Guid id) : base(id)
    { }
    public Model? Model { get; private set; }
    public string? Vin { get; private set; }
    public Direction? Direction { get; private set; }
    public decimal Price { get; private set; }
    public string? Money {get; private set; }
    public decimal Maintenance { get; private set; }
    public string? MaintenanceMoney { get; private set; }
    public DateTime LastRentDate { get; private set; }
    public List<Accessories> Accessories { get; private set; } = new();
}