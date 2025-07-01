try
{
    Beer beer = new Beer()
    {
        Name = "London Porter",
        //Brand = "Fuller's"
    };
    
    Console.WriteLine(beer.ToString());
}
catch (InvalidBeerException ex)
{
    Console.WriteLine(ex.Message);
}

public class InvalidBeerException : Exception
{
    public InvalidBeerException() : base("La cerveza no tiene nombre o marca, por lo cual no es valido")
    {
        
    }
}

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
    
    
    public override string ToString()
    {
        if (Name == null || Brand == null)
            throw new InvalidBeerException();
            
        return $"Name: {Name}, Brand: {Brand}";
    }
}

