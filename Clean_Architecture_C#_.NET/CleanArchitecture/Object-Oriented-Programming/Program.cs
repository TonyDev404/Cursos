using Object_Oriented_Programming.Business;

Beer erdingerBeer = new Beer("Erdinger", 3, -2, 1000);
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01), 330);
Drink drink = new Beer("Erdinger", 3, -2, 1000);

// Console.WriteLine(delirium.GetCategory());
// Console.WriteLine(erdingerBeer.GetInfo());
// Console.WriteLine(delirium.GetInfo());
// Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
// Console.WriteLine(delirium.GetInfo(2));

// Drink drink = new Wine(500); 
//No se usa "new Drink" porque es abstratca y solo sirve para definir algo que es
//abstracto pero no para crear objetos
// Show(drink);
// drink = new Beer("Corona", 2, 4, 330);
// Show(drink);
// Show(erdingerBeer);

SendSome(erdingerBeer);
SendSome(delirium);

void Show(Drink drink) => Console.WriteLine(drink.GetCategory());

void SendSome(ISend some)
{
    Console.WriteLine("hago algo");
    some.Send();
    Console.WriteLine("hago algo mas");
}
//========================================================================
var service = new Service(100, 10);

ISalable[] concepts = [
    erdingerBeer,
    delirium,
    service
];

Console.WriteLine(GetTotal(concepts));

decimal GetTotal(ISalable[] conecpts)
{
    decimal total = 0;
    foreach (var concept in concepts)
    {
        total += concept.GetPrice();
    }

    return total;
}

//========================================================================

var elements = new Collection<int>(3);
elements.Add(100);
elements.Add(150);
elements.Add(200);
elements.Add(500); //No se muestra porque supera el limite

Console.WriteLine(" ");
foreach (var element in elements.Get())
{
    Console.WriteLine(element);
}

var names = new Collection<string>(2);
names.Add("Antonio");
names.Add("Jose");

foreach (var name in names.Get())
{
    Console.WriteLine(name);
}

var beers = new Collection<Beer>(2);
beers.Add(erdingerBeer);
beers.Add(delirium);

foreach (var beer in beers.Get())
{
    Console.WriteLine(beer.GetInfo()); 
}

//========================================================================

Console.WriteLine($"Objectos creados: {Beer.QuantityObjects}");
Console.WriteLine(Operations.Add(1,2));
Console.WriteLine(Operations.Mul(10, 20));