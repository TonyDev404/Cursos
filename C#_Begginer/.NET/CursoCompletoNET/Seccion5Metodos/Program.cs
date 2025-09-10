// See https://aka.ms/new-console-template for more information

//
// int opcion;
// decimal r; //Almacena el valor devuelto de resta
// decimal num1Ar, num2Ar; //argumentos para enviar una copia de su valor a los métodos
//
// do
// {
//     Console.WriteLine("1) Suma");
//     Console.WriteLine("2) Resta");
//     Console.WriteLine("3) Multiplicación");
//     Console.WriteLine("4) Division");
//
//     Console.WriteLine("Que operación desea realizar");
//     opcion = byte.Parse(Console.ReadLine());
// } while ((opcion < 1) || (opcion > 4));
//
//
// switch (opcion)
// {
//     case 1:
//         Sumar();
//         break;
//     case 2:
//         r = Resta(); //Asignamos a "r" el valor devuelvo por "return"
//
//         //Mostramos el resultado, con la información que contiene "r"
//         Console.WriteLine($"El resultado de la esta es: {r}");
//         break;
//     case 3:
//         num1Ar = IngresarNumero("Ingresa el primer número: ");
//         num2Ar = IngresarNumero("Ingresa el segundo número:");
//         //Invocamos al método
//         Multiplicar(num1Ar, num2Ar);
//         break;
//     case 4:
//         num1Ar = IngresarNumero("Ingresa el primer número: ");
//         num2Ar = IngresarNumero("Ingresa el segundo número:");
//
//         r = Dividir(num1Ar, num2Ar);
//         Console.WriteLine($"El resultado de la división es: {r}");
//         break;
//     default:
//         Console.WriteLine("Opción no valida");
//         break;
// }
//
// //1. Métodos sin parámetros ni tipo
// static void Sumar()
// {
//     decimal num1, num2, resultado;
//
//     Console.WriteLine("Ingresa el primer número: ");
//     num1 = decimal.Parse(Console.ReadLine());
//
//     Console.WriteLine("Ingresa el segundo número: ");
//     num2 = decimal.Parse(Console.ReadLine());
//
//     resultado = num1 + num2;
//
//     Console.WriteLine($"{num1} + {num2} = {resultado}");
// }
//
// //2. Métodos que devuelven un tipo
// static decimal Resta()
// {
//     decimal num1, num2, resultado;
//
//     Console.WriteLine("Ingresa el primer número: ");
//     num1 = decimal.Parse(Console.ReadLine());
//
//     Console.WriteLine("Ingresa el segundo número: ");
//     num2 = decimal.Parse(Console.ReadLine());
//
//     resultado = num1 - num2;
//
//     return resultado;
// }
//
// //3. Métodos con parámetros
// //[modificador] [tipo] [identificador] [parámetros]
// static void Multiplicar(decimal num1, decimal num2)
// {
//     decimal total = num1 * num2;
//     Console.WriteLine($"{num1} * {num2} = {total}");
// }
//
// //4. Métodos con parámetros y que devuelven un tipo
// static decimal Dividir(decimal num1, decimal num2)
// {
//     decimal total = 0;
//
//     if (num2 != 0)
//     {
//         total = num1 / num2;
//     }
//     else
//     {
//         Console.WriteLine("No es posible dividir entre cero");
//         total = 0;
//     }
//
//     return total;
// }
//
// static decimal IngresarNumero(string peticion)
// {
//     //variable local al método
//     decimal numero;
//     
//     //pedimos el valor según coresponda
//     Console.WriteLine(peticion);
//     
//     //convertimos y asignamos
//     numero = Convert.ToDecimal(Console.ReadLine());
//     
//     //devolvemos el valor de tipo decimal
//     return numero;
//
// }
//=============================================================================================

//======Pasa por valor======
// //Variable local a Main(argumento)
// byte numAr;
//
// //Asignamos un valor
// numAr = 10;
//
// //Mostramos su valor en la consola
// Console.WriteLine(numAr);
//
// //Invocamos al metodo y mandamos al argumento
// PruebasinRef(numAr); //No cambia el valor
//
// //Después de que el metodo cambio el valor, volvemos a mostrar al argumento
// Console.WriteLine(numAr);
//
//======Pasa por referencia======
// PruebaRef(ref numAr);
// Console.WriteLine(numAr);
// //Pasar por valor
// static void PruebasinRef(byte numPa)
// {
//     //Modificacmos el valor del parametro
//     numPa = 20;
// }
//
// //Pasar por referencia
// static void PruebaRef(ref byte numPa)
// {
//     //Modificacmos el valor del parametro
//     numPa = 20;
// }

//=============================================================================================
//======Palabra out======

// //Variable local a Main(argumento)
// byte numAr;
// string saludoAr;
// int numPrimoAr;
// //No inicializamos las variables y se las podemos pasar como argumento al metodo directamente con la palabra out
//
// //Invocamos al metodo y mandamos a los argumentos
// Prueba(out numAr, out saludoAr, out numPrimoAr);
//
// Console.WriteLine($"{numAr} {saludoAr} {numPrimoAr}");
//
// static void Prueba(out byte numPa, out string saludoAr, out int numPrimoAr)
// {
//     //Modificamos el valor de los parametros
//     numPa = 20;
//     saludoAr = "Hola a todos";
//     numPrimoAr = 7;
// }


//=============================================================================================
//======Tuplas======

// string nombre = "Antonio";
// byte edad = 50;
// long numero = 5522009933;
// int codigoPostal = 321122;
//
// //(tipo) Identificador = (valor);
// // (string, byte, long, int) -> de manera explícita
//
// // var persona1 = ("Antonio", 50, 5522009933, 321122);
// // (string nombre, byte edad, long numero, int codigoPostal) persona1 = ("Antonio", 50, 5522009933, 321122);
// var persona1 = (nombre: "Antonio", edad: 50, telefono: 5522009933, codigoPostal: 321122); // -> a estos datos se les llama "campos"
//
// //Items
// Console.WriteLine(persona1.nombre);
// Console.WriteLine(persona1.edad);
// Console.WriteLine(persona1.telefono);
// Console.WriteLine(persona1.codigoPostal);
//

// var num1 = 0;
// var num2 = 0;
// var opcion = 0;
// var resultado = 0;
//
// (decimal num1, decimal num2, decimal resultado) numeros;
//
// do
// {
//     Console.WriteLine("1) Suma");
//     Console.WriteLine("2) Resta");
//     Console.WriteLine("3) Multiplicación");
//     Console.WriteLine("4) Division");
//     
//     Console.WriteLine("Que operación desea realizar");
//     opcion = byte.Parse(Console.ReadLine());
// } while ((opcion < 1) || (opcion > 4));
//
// switch (opcion)
// {
//     case 1:
//         resultado = num1 + num2;
//         break;
//     case 2:
//         numeros = Restar(); //Asignamos a la tupla "numeros"  los 3 valores devueltos por "return"
//         
//         Console.WriteLine($"{numeros.num1} - {numeros.num2} = {numeros.resultado}");
//         break;
//     case 3:
//         resultado = num1 * num2;
//         break;
//     case 4: 
//         resultado = num1 / num2;
//         break;
//     default:
//         Console.WriteLine("Opción no valida");
//         break;
// }
//
// Console.WriteLine($"El resultado es: {resultado}");
//
// static void Sumar()
// {
//     decimal num1, num2, resultado;
//
//     Console.WriteLine("Ingresa el primer número: ");
//     num1 = decimal.Parse(Console.ReadLine());
//
//     Console.WriteLine("Ingresa el segundo número: ");
//     num2 = decimal.Parse(Console.ReadLine());
//
//     resultado = num1 + num2;
//
//     Console.WriteLine($"{num1} + {num2} = {resultado}");
// }
//
// static (decimal, decimal, decimal) Restar()
// {
//     decimal num1, num2, resultado;
//
//     Console.WriteLine("Ingresa el primer número: ");
//     num1 = decimal.Parse(Console.ReadLine());
//
//     Console.WriteLine("Ingresa el segundo número: ");
//     num2 = decimal.Parse(Console.ReadLine());
//
//     resultado = num1 - num2;
//
//     //Devolvemos multiples tipos al autor del llamado
//     return (num1, num2, resultado);
// }
//
// static void Multiplicar(decimal num1, decimal num2)
// {
//     decimal total = num1 * num2;
//     Console.WriteLine($"{num1} * {num2} = {total}");
// }
//
// static decimal Dividir(decimal num1, decimal num2)
// {
//     decimal total = 0;
//
//     if (num2 != 0)
//     {
//         total = num1 / num2;
//     }
//     else
//     {
//         Console.WriteLine("No es posible dividir entre cero");
//         total = 0;
//     }
//
//     return total;
// }
//
// static decimal IngresarNumero(string peticion)
// {
//     //variable local al método
//     decimal numero;
//     
//     //pedimos el valor según coresponda
//     Console.WriteLine(peticion);
//     
//     //convertimos y asignamos
//     numero = Convert.ToDecimal(Console.ReadLine());
//     
//     //devolvemos el valor de tipo decimal
//     return numero;
//
// }


//=============================================================================================
//======Tarea 1======

// double gradosAr, radianes;
//
// Console.WriteLine("Ingresa los grados: ");
// gradosAr = double.Parse(Console.ReadLine());
//
// //Invocamos al metodo
// radianes = transformGradToRad(gradosAr);
//
// //Mostramos el resultado con el valor devuelto del metodo
// Console.WriteLine($"El resultado de {gradosAr} grados a radianes es de: {radianes}");
//
// static double transformGradToRad(double grad)
// {
//     double radianes;
//     var resultado = (grad * Math.PI) / 180;
//     
//     return resultado;
// }
//

//======Tarea 2======

var opcion = 0;
double resultado = 0;

do
{
    Console.WriteLine("1) Circulo");
    Console.WriteLine("2) Cuadrado");
    Console.WriteLine("3) Triangulo");

    Console.WriteLine("De que figura desea calcular el area");
    opcion = byte.Parse(Console.ReadLine());
} while ((opcion < 1) || (opcion > 3));

switch (opcion)
{
    case 1:
        resultado = circuloArea();

        Console.WriteLine($"Resultado {resultado}");
        break;
    case 2:
        resultado = trianguloArea();
        
        Console.WriteLine($"Resultado {resultado}");
        break; 
    case 3:
        resultado = cuadradoArea();
        Console.WriteLine($"Resultado {resultado}");
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;
}


static double circuloArea()
{
    var pi = Math.PI;

    Console.WriteLine("Introduzca el radio: ");
    var radio = double.Parse(Console.ReadLine());

    var resultado = pi * (radio * radio);

    return resultado;
}


static double trianguloArea()
{
    Console.WriteLine("Introduzca la base: ");
    var b = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Introduzca la altura: ");
    var h = double.Parse(Console.ReadLine());

    var resultado = (b * h) / 2;
    
    return resultado;
}


static double cuadradoArea()
{
    Console.WriteLine("Introduzca el valor de alguno de los lados: ");
    var lado = double.Parse(Console.ReadLine());

    var resultado = Math.Pow(lado, 2);

    return resultado;
}
