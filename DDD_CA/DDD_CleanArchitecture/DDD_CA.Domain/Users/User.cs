using DDD_CA.Domain.Abstractoins;

namespace DDD_CA.Domain.Users;

public sealed class User : Entity
{
    public User(Guid Id) : base(Id)
    {
        
    }
}