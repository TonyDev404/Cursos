var beers = new List<Beer>()
{
    new Beer() { Name = "Corona", Country = "México" },
    new Beer() { Name = "Delirium", Country = "Bélgica" },
    new Beer() { Name = "Erdinger", Country = "Alemania" },
};


foreach (var beer in beers)
{
    Console.WriteLine(beer);
}

Console.WriteLine("-------------------------");

//Select
var beersName = from b in beers
    select new
    {
        Name = b.Name,
        Letters = b.Name.Length,
        Fixed = 1
    };

foreach (var beer in beersName)
{
    Console.WriteLine($"{beer.Name} {beer.Letters}, Fixed: {beer.Fixed}");
}

Console.WriteLine("-------------------------");

var beersNameReal = from b in beersName
    select new
    {
        Name = b.Name
    };

foreach (var beer in beersNameReal)
{
    Console.WriteLine(beer.Name);
}

Console.WriteLine("-------------------------");

// var beersMexico = from b in beers
//     where b.Country == "México"
//     select b;
// && and, || or

var beersMexico = from b in beers
    where b.Country == "México"
    || b.Country == "Alemania"
    select b;

foreach (var beer in beersMexico)
{
    Console.WriteLine(beer); //Se manda a llamar el método ToString
}

Console.WriteLine("-------------------------");

// var orderedBeers = from b in beers
//     orderby b.Country
//         select b;

var orderedBeers = from b in beers
    orderby b.Country descending
    select b;

foreach (var beer in orderedBeers)
{
    Console.WriteLine(beer);
}

Console.WriteLine("-------------------------");



class Beer
{
    public string Name { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Name}, País: {Country}";
    }
}