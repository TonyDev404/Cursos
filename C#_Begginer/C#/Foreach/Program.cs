var numbers = new List<int>()
{
    23, 3, 5, 10, 22, 12  
};

foreach (var number in numbers)
{
    Console.WriteLine(number);
};




static void Show(List<People> students)
{
    Console.WriteLine("-- Personas --");
    foreach (var people in students)
    {
        Console.WriteLine($"Nombre: {people.Name}, Pais: {people.Country}");
    }
}

var students = new List<People>()
{
    new People() { Name = "Antonio", Country = "Mexico" },
    new People() { Name = "Roberto", Country = "Argentina" },
    new People() { Name = "Ana", Country = "Canada" },
};

Show(students);

students.RemoveAt(0);


class People
{
    public string Name { get; set; }
    public string Country { get; set; }
}
