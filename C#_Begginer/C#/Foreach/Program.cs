

<<<<<<< HEAD
var numbers = new List<int>()
{
  23, 3, 5, 10, 22, 12  
};

foreach (var number in numbers)
{
  Console.WriteLine(number);
=======
var n = 5;

static void Show(List<People> students)
{
    Console.WriteLine("\n-- Personas --");

    foreach (var people in students)
    {
        Console.WriteLine($"Nombre: {people.Name}, País: {people.Country}");
    }
>>>>>>> a9403d03ff852d6b56c41a212387fe3e1d46e1c4
}

var students = new List<People>()
{
<<<<<<< HEAD
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
=======
    new People() { Name = "Antonio", Country = "México" },
    new People() { Name = "Joel", Country = "Colombia" },
    new People() { Name = "Angel", Country = "Francia" }
};

Show(students);

students.RemoveAt(0);

Show(students);
class People
{
    public string Name { get; set; }
    public string Country { get; set; }
}

//===========================================================================

// var numbers = new List<int>()
// {
//     23, 3, 5, 10, 22, 12
// };
//
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }
//===========================================================================

>>>>>>> a9403d03ff852d6b56c41a212387fe3e1d46e1c4
