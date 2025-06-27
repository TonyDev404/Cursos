

var antonio = new
{
  Name = "Antonio",
  Country = "Mexico"
};

Console.WriteLine($"{antonio.Name} {antonio.Country}");

var beers = new[]
{
  new { Name = "Red", Brand = "Delirium" },
  new { Name = "London Porter", Brand = "Fullers" },
}; //Todos los elementos dentro de la coleccion deben tener la misma estructure

foreach (var p in beers)
{
  Console.WriteLine($"Cerveza: {p.Name} {p.Brand}");
}