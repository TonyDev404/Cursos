
Operation mySum = Functions.Sum;
// Console.WriteLine(mySum(2, 3));

mySum = Functions.Mul;
// Console.WriteLine(mySum(2,3));

// Show show = Functions.ConsoleShow;
// show("Hola mundo");

// Show cw = Console.WriteLine; //Va primero esta función
// cw += Functions.ConsoleShow; //Luego ejecuta la que lo convierte en mayus
//cw("Holitas");
// Functions.Some("Juan", "Guevara", cw);

#region Action

// string hi = "Hola,";
// Action<string> showMessage = Console.WriteLine;
// Action<string, string> showMessage2 = (a, b) =>
// {
//     Console.WriteLine($"{hi} {a} {b}");
// }; //Cuando tenemos mas de una linea de codigo en la expresion, debemos poner las llaves
//     //Tambien podemos acceder a elementos externos
//     showMessage2("Antonio", "Narvaez");
//
// Action<string, string, string> showMessage3 = (a, b, c) => Console.WriteLine($"{a} {b} {c}");
// showMessage3("Antonio", "Narvaez", "Dev");
//
// Functions.SomeAction("Antonio", "Narvaez", (a) =>
// {
//     Console.WriteLine("soy una expresion lambda " + a);
// });

// Functions.SomeAction("Antonio", "Narvaez", showMessage);
#endregion

#region Func
// Func<int> numberRandom = () => new Random().Next(0, 100);
// Func<int, int> numberRandomLimit = (limit) => new Random().Next(0, limit); //El ultimo valor de Func es lo que va a devolver
// Func<int, string> numberRandomLimit2 = (limit) => new Random().Next(0, limit).ToString();
//
// // Func<int, int> numberRandomLimit = (limit) =>
// // {
// //     return new Random().Next(0, limit);
// // };
// Console.WriteLine(numberRandom());
// Console.WriteLine(numberRandomLimit(10000));
#endregion

#region Predicate

// Predicate<string> hasSpace = (word) => word.Contains(" "); //No puede tener mas de un parametro <string>, <int>, etc..
// Console.WriteLine(hasSpace("pa ti to"));
Predicate<string> hasSpaceOrA = (word) => word.Contains(" ") || word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceOrA("beera"));
Console.WriteLine(hasSpaceOrA("pa ti to"));

var words = new List<string>()
{
    "beer",
    "patito",
    "sandia",
    "hola mundo",
    "c#"
};

var wordsNew = words.FindAll((w) => !hasSpaceOrA(w));

foreach (var w in wordsNew) Console.WriteLine(w);
#endregion


#region Delegados
delegate int Operation(int a, int b);
public delegate void Show(string message);
public delegate void Show2(string message, string message2);
public delegate void Show3(string message, string message2, string message3);
#endregion

public class Functions
{
    public static int Sum(int x, int y) => x + y; //Poner la flecha cuando solo tengamos una línea para nuestra función
    public static int Mul(int num1, int num2) => num1 * num2;

    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }
    
    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }
}
