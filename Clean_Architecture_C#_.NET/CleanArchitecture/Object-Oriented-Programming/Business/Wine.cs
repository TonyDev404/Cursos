namespace Object_Oriented_Programming.Business;

public class Wine : Drink
{
    private const string Category = "Vino";
    public Wine(int quantity) : base (quantity) { }
    public override string GetCategory() => Category;
}