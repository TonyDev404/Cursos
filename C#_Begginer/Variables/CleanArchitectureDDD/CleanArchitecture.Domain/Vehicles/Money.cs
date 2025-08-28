namespace CleanArchitecture.Domain.Vehicles;

public record Money(
    decimal Amount,
    CurrencyType CurrencyType)
{
    public static Money operator +(Money first, Money second)
    {
        if (first.CurrencyType != second.CurrencyType)
        {
            throw new InvalidOperationException("Currency Type must be the same");
        }
        return new Money(first.Amount + second.Amount, first.CurrencyType);
        //Le pasamoe first.currencyType porque ambos deben tener el mismo tipo de moneda
    }
    
    public static Money Zero() => new(0, CurrencyType.None);
    public static Money Zero(CurrencyType currencyType) => new(0, currencyType);
    public bool IsZero() => this == Zero(CurrencyType);
};