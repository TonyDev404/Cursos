
using System.Text.Json;

Beer myBeer = new Beer()
{
    Name = "Pikantus",
    Brand = "Erdinger"
};

// string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}";

string json = JsonSerializer.Serialize(myBeer);
Beer beer = JsonSerializer.Deserialize<Beer>(json);

Beer[] beers = new Beer[]
{
    new Beer()
    {
        Name = "Pikantus",
        Brand = "Erdinger"
    },
    new Beer()
    {
        Name = "Corona",
        Brand = "Modelo"
    }
};

string json2 = JsonSerializer.Serialize(beers);
Beer[] beer2 = JsonSerializer.Deserialize<Beer[]>(json2);

// string json2 = "[" +
//        "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}, +" +
//        "{\"Name\": \"Corona\", \"Brand\": \"Modelo\"}" +
//        "]";

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
}
