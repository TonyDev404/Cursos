People antonio = new People()
{
    Name = "Antonio",
    Age = 23
};

People juan = new People()
{
    Name = "Juan",
    Age = 30
};


Console.WriteLine(People.GetCount());

public static class A //Todo debe ser estatico en la clase
{
    public static void Some()
    {
        Console.WriteLine("algo");
    }
}

public class People
{
    public static int Count = 0; //Propiedad global y unica en la clase
    public string Name { get; set; }
    public int Age { get; set; }

    public People()
    {
        Count++;
    }
    
    public static string GetCount()
    {
        return $"Esta clase se ha utilizado {Count} veces";
    }
}