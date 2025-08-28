namespace CleanArchitecture.Domain.Abstractions;

public abstract class Entity(Guid id)
{
    private readonly List<IDomainEvent> _domainEvents = [];
    public Guid Id { get; init; } = id; //una vez que definamos una entidad su identificacion va a quedar establecida de por vida

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}