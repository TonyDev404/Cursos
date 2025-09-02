namespace DDD_CA.Domain.Vehicles;

public record Money(decimal Amount, TypeMoney TypeMoney)
{
    public static Money operator +(Money first, Money second)
    {
        if (first.TypeMoney != second.TypeMoney)
        {
            throw new InvalidOperationException("The kind of Money must be the same");
        }
        
        return new Money(first.Amount + second.Amount, first.TypeMoney);
        //Se puede usar cualquier tipo de moneda ya sea del primero o segundo porque siempre debe ser el mismo
    }

    public static Money Zero() => new(0, TypeMoney.None);
    //Solo es para inicializar un objeto
    public static Money Zero(TypeMoney typeMoney) => new(0, typeMoney);
    
    public bool IsZero() => this == Zero(TypeMoney);
};