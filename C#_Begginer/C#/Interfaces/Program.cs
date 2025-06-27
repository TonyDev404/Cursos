Shark[] sharks = new Shark[]
{
    new Shark("Tiburonsin", 56),
    new Shark("Jaws", 65),
};

IFish[] fishs = new IFish[] //Las Interfaces no sirven para crear objetos, sino, para darle una categorizacion al objeto
{
    new Siren(100),
    new Shark("Totino", 40)
};


ShowFish(sharks);
ShowAnimals(sharks);
ShowFish(fishs);


static void ShowAnimals(IAnimal[] animals)
{
    Console.WriteLine("- Mostramos los peces --");
    int i = 0;
    while (i < animals.Length)
    {
        Console.WriteLine(animals[i].Name);
        i++;
    }
}

static void ShowFish(IFish[] fishs)
{
    Console.WriteLine("- Mostramos los peces --");
    int i = 0;
    while (i < fishs.Length)
    {
        Console.WriteLine(fishs[i].Swim());
        i++;
    }
}

public class Siren : IFish
{
    public int Speed { get; set; }

    public Siren(int speed)
    {
        this.Speed = speed;
    }

    public string Swim()
    {
        return $"La sirena nada a {Speed} km/h";
    }
}

public class Shark : IAnimal, IFish
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Shark(string name, int speed)
    {
        this.Name = name;
        this.Speed = speed;
    }

    public string Swim()
    {
        return $"{Name} nada {Speed} km/h";
    }
}

public interface IAnimal
{
    public string Name { get; set; }
}

public interface IFish
{
    public int Speed { get; set; }
    public string Swim();
}

