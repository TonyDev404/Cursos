namespace Object_Oriented_Programming.Business;

public abstract class Drink
{
    public int Quantity { get; set; }

    public Drink(int quantity)
    {
        this.Quantity = quantity;
    }

    public string GetQuantity()
    {
        return Quantity + " ml";
    }

    public abstract string GetCategory(); 
    //No hace nada, el metodo se puede recibir de quien hereda, y debe crear ese metodo
    //Clase abstracta son cosas que sabemos que no van a cambiar, sabemos que tiene ese objeto
}