namespace DDD_CA.Domain.Vehicles;

public record TypeMoney
{
    public static readonly TypeMoney None = new("");
    public static readonly TypeMoney Usd = new("USD");
    public static readonly TypeMoney Eur = new("EUR");
    private TypeMoney(string codigo) => Codigo = codigo;
    public string? Codigo { get; init; }

    public static readonly IReadOnlyCollection<TypeMoney> All = new[]
    {
        Usd,
        Eur
    };

    public static TypeMoney FromCode(string codigo)
    {
        return All.FirstOrDefault(c => c.Codigo == codigo) ?? throw new ApplicationException($"Code {codigo} not found");
    }
}