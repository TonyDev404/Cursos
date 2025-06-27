

List<int> numbers = new List<int>()
{
  4, 3, 5, 19  
};

Show(numbers);

numbers.Insert(0, 6); //index, value
Show(numbers);

//Contains
if (numbers.Contains(19))
{
  Console.WriteLine("Existe");
}
else
{
  Console.WriteLine("No existe");
}

//IndexOf
int pos = numbers.IndexOf(19);
Console.WriteLine(pos);

pos = numbers.IndexOf(100);
Console.WriteLine(pos); //Si no existe, regresa un -1

//Sort
numbers.Sort();
Show(numbers);

//Add Range

var numbers2 = new List<int>()
{
  200, 300, 400
};
// numbers.AddRange(new List<int>()
// {
//   200, 300, 400
// });
// Show(numbers);

numbers.AddRange(numbers2);
Show(numbers);

static void Show(List<int> numbers)
{
  Console.WriteLine("-- Numeros --");
  foreach (var n in numbers)
  {
    Console.WriteLine(n);
  }
}