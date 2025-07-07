var t = TomorrowPure;
Console.WriteLine(t(new DateTime(2024, 05, 01, 00, 00, 00)));

//Action no retorna nada (void)
Action<string> show = Console.WriteLine;
show("Hola");

Action<string> hi = name => Console.WriteLine($"Hola {name}"); 
//Las expresiones lambda permite escribir funciones anonimas
hi("Antonio");
Action<int, int> add = (a, b) => show((a+b).ToString());
add(5, 2);

Func<int, int, int> mul = (a, b) => a * b; //El último valor de <> es el tipo que va a regresar
// show(mul(3, 4).ToString());
Func<int, int, string> mulString = (a, b) =>
{
    var res = a * b;
    return res.ToString();
};
// show(mulString(5, 5));

List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

Predicate<int> condition = x => x % 2 == 0; //Nos devuelve in booleano y no puede recibir mas de un parametro
Predicate<int> condition2 = x => x > 5;

var numbers2 = Filter(numbers, condition); 
var numbers3 = Filter(numbers, condition2);

foreach (var number in numbers2)
{
    Console.WriteLine(number);
}

foreach (var number in numbers3)
{
    Console.WriteLine(number);
}


List<int> Filter(List<int> list, Predicate<int> condition)
{
    var resultsList = new List<int>();
    foreach (var element in list)
    {
        if (condition(element))
        {
            resultsList.Add(element);
        }
    }
    return resultsList;
}


// var numbers2 = Filter(numbers, number => number % 2 == 0); 
// //Podemos modificar su funcionamiento interno de una funcion de orden superior
// var numbers3 = Filter(numbers, number => number > 5);

// List<int> Filter(List<int> list, Func<int, bool> condition)
// {
//     var resultsList = new List<int>();
//     foreach (var element in list)
//     {
//         if (condition(element))
//         {
//             resultsList.Add(element);
//         }
//     }
//     return resultsList;
// }

//Funcion no pura
DateTime Tomorrow()
{
    return DateTime.Now.AddDays(1);
}

Beer ToUpper(Beer beer)
{
    beer.Name = beer.Name.ToUpper();
    return beer;
}

//Funcion Pura
DateTime TomorrowPure(DateTime date)
{
    return date.AddDays(1);
}

Beer ToUpperPure(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper(),
    };
    return beer2;
}

public class Beer
{
    public string Name { get; set; }
}
