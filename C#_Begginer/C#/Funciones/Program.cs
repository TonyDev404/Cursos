int a = 1;
int b = 2;

static int Mul(int num1, int num2)
{
    return num1 * num2;
}

static void Sum(int num1, int num2)
{
    Console.WriteLine(num1 + num2);
}

static void Show()
{
    Console.WriteLine("Hola, soy un texto que se imprime desde funcion");
}

Show();
Sum(1, 2);
Sum(3, 4);

int m = Mul(5, 5);
Console.WriteLine(m);
Console.WriteLine(Mul(5, 10));