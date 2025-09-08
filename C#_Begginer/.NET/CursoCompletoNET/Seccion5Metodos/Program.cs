// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int opcion;
decimal r; //Almacena el valor devuelto de resta
decimal num1Ar, num2Ar; //argumentos para enviar una copia de su valor a los métodos

do
{
    Console.WriteLine("1) Suma");
    Console.WriteLine("2) Resta");
    Console.WriteLine("3) Multiplicación");
    Console.WriteLine("4) Division");

    Console.WriteLine("Que operación desea realizar");
    opcion = byte.Parse(Console.ReadLine());
} while ((opcion < 1) || (opcion > 4));


switch (opcion)
{
    case 1:
        Sumar();
        break;
    case 2:
        r = Resta(); //Asignamos a "r" el valor devuelvo por "return"

        //Mostramos el resultado, con la información que contiene "r"
        Console.WriteLine($"El resultado de la esta es: {r}");
        break;
    case 3:
        num1Ar = IngresarNumero("Ingresa el primer número: ");
        num2Ar = IngresarNumero("Ingresa el segundo número:");
        //Invocamos al método
        Multiplicar(num1Ar, num2Ar);
        break;
    case 4:
        num1Ar = IngresarNumero("Ingresa el primer número: ");
        num2Ar = IngresarNumero("Ingresa el segundo número:");

        r = Dividir(num1Ar, num2Ar);
        Console.WriteLine($"El resultado de la división es: {r}");
        break;
    default:
        Console.WriteLine("Opción no valida");
        break;
}

//1. Métodos sin parámetros ni tipo
static void Sumar()
{
    decimal num1, num2, resultado;

    Console.WriteLine("Ingresa el primer número: ");
    num1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa el segundo número: ");
    num2 = decimal.Parse(Console.ReadLine());

    resultado = num1 + num2;

    Console.WriteLine($"{num1} + {num2} = {resultado}");
}

//2. Métodos que devuelven un tipo
static decimal Resta()
{
    decimal num1, num2, resultado;

    Console.WriteLine("Ingresa el primer número: ");
    num1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa el segundo número: ");
    num2 = decimal.Parse(Console.ReadLine());

    resultado = num1 - num2;

    return resultado;
}

//3. Métodos con parámetros
//[modificador] [tipo] [identificador] [parámetros]
static void Multiplicar(decimal num1, decimal num2)
{
    decimal total = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {total}");
}

//4. Métodos con parámetros y que devuelven un tipo
static decimal Dividir(decimal num1, decimal num2)
{
    decimal total = 0;

    if (num2 != 0)
    {
        total = num1 / num2;
    }
    else
    {
        Console.WriteLine("No es posible dividir entre cero");
        total = 0;
    }

    return total;
}

static decimal IngresarNumero(string peticion)
{
    //variable local al método
    decimal numero;
    
    //pedimos el valor según coresponda
    Console.WriteLine(peticion);
    
    //convertimos y asignamos
    numero = Convert.ToDecimal(Console.ReadLine());
    
    //devolvemos el valor de tipo decimal
    return numero;

}