

var numbers = new List<int>()
{
  23, 3, 5, 10, 22, 12  
};

foreach (var number in numbers)
{
  Console.WriteLine(number);
}

var students = new List<People>()
{
  new People() { Name = "Antonio", Country = "Mexico" },
  new People() { Name = "Roberto", Country = "Argentina" },
  new People() { Name = "Ana", Country = "Canada" },
};

static void Show(List<People> students)
{
  Console.WriteLine("-- Personas --");
  foreach (var people in students)
  {
    Console.WriteLine($"Nombre: {people.Name}, Pais: {people.Country}");
  }
}


class People
{
  public string Name { get; set; }
  public string Country { get; set; }
}