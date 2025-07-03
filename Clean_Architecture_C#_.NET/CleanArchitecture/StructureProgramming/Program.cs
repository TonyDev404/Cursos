//Arrays

using System.Runtime.InteropServices.JavaScript;

int[] numbers = new int[5];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

int[] numbers2 = new int[5]
{
    1, 2, 3, 4, 5
};

// Console.WriteLine(numbers2[2]);

//======================================================================================================================
//Sentencias de iteracion
var names = new string[3]
{
  "Antonio", "Juan", "Pedro" 
};

int i = 0;

// do
// {
//     Console.WriteLine(names[i]);
//     i++;
// }while(i < names.Length);

// while (i < names.Length)
// {
//     Console.WriteLine(names[i]);
//     i++;
// };

// for (int idx = 0; idx<names.Length; idx++)
// {
//     Console.WriteLine(names[idx]);
// }

//======================================================================================================================
//Funciones

// //sin funcion
// int res1 = 30 * 30;
// Console.WriteLine(res1);
//
// //con funciones
// int res3 = Area(30);
// Console.WriteLine(res3);
//
// Show("Aquitectura Limpia");
// Bye();
//
// int Area(int s)
// {
//     int res = s * s;
//     return res;
// };
//
// void Show(string message)
// {
//     Console.WriteLine(message);
// }
//
// void Bye()
// {
//     Show("Ayoos");
// }

//======================================================================================================================
//Programa con paradigma estructurado

int limit = 10;
var beers = new string[limit];
int iBeers = 0;
int op = 0;

do
{
    Console.Clear();
    ShowMenu();
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            if (iBeers < limit)
            {
                Console.Clear();
                Console.WriteLine("Escribe un nombre de cerveza: ");
                var beer =  Console.ReadLine();
                beers[iBeers] = beer;
                iBeers++;
            }
            else
            {
                Console.WriteLine("Ya no caben cervezas");
            }
            break;
        case 2:
            ShowBeers(beers, iBeers);
            break;
        case 3:
            Console.WriteLine("Adios");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
    
} while (op != 3);

void ShowMenu()
{
    Console.WriteLine("1.Agregar nombre");
    Console.WriteLine("2.Mostrar nombre");
    Console.WriteLine("3. Salir");
}

void ShowBeers(string[] beers, int iBeers)
{
    Console.Clear();
    Console.WriteLine("-----Cervezas-----");

    for (int i = 0; i <= iBeers; i++)
    {
        Console.WriteLine(beers[i]);
    }

    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadLine();
}