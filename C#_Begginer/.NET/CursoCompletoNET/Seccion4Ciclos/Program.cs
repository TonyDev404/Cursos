// int i;
// int j;
//
// i = 10;
// Console.WriteLine("Valor inicial del operando: {0}", i);
//
// //Incremento como sufijo e imprimimos
// Console.WriteLine("Valor con incremento incluido: {0}", i++); //sufijo
//
// //Ya no incrementamos, solo imprimimos
// Console.WriteLine(i);
//
// j = 10;
// Console.WriteLine("Valor inicial del operando: {0}", j);
//
// //Incremento como prefijo e imprimimos
// Console.WriteLine("Valor con incremento incluido: {0}", ++j); //prefijo
//
// Console.WriteLine("--------------------------------");
// int n = 20;
//
// Console.WriteLine("Valor inicial del operando: {0}", n);
//
// //Decremento como sufijo e imprimimos
// Console.WriteLine("Valor con decremento incluido: {0}", n--); //sufijo
// Console.WriteLine(n);
//
// //Decremento como prefijo e imprimimos
// Console.WriteLine("Valor con decremento incluido: {0}", --n); //prefijo

//=====================================================================
//=====FOR=====

// double calif1, calif2, calif3, calif4, calif5, calif6, calif7, promedio;
//
// Console.WriteLine("Ingresa la calificacion del primer alumno: ");
// calif1 = double.Parse(Console.ReadLine());
//
//
// Console.WriteLine("Ingresa la calificacion del segundo alumno: ");
// calif2 = double.Parse(Console.ReadLine());
//
//
// Console.WriteLine("Ingresa la calificacion del tercer alumno: ");
// calif3 = double.Parse(Console.ReadLine());
//
// Console.WriteLine("Ingresa la calificacion del cuarto alumno: ");
// calif4 = double.Parse(Console.ReadLine());
//
// Console.WriteLine("Ingresa la calificacion del quinto alumno: ");
// calif5 = double.Parse(Console.ReadLine());
//
// Console.WriteLine("Ingresa la calificacion del sexto alumno: ");
// calif6 = double.Parse(Console.ReadLine());
//
// Console.WriteLine("Ingresa la calificacion del septimo alumno: ");
// calif7 = double.Parse(Console.ReadLine());
//
// //Calculamos el promedio
// promedio = (calif1 + calif2 + calif3 + calif4 + calif5 + calif6 + calif7) / 7;
//
// //Pomedio
// Console.WriteLine($"El promedio es: {promedio}");

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }
//Declaracion e inicializacion de una variable de control
//Una instruccion de asignacion

// for (var i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }

// int i;
// int contador = 0;
//
// for (i = 1; i <= 10; i++)
// {
//     contador++;
//     Console.WriteLine(contador);
// }

// int acumulador = 0;
// int precio;
//
// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine("Ingresa el precio del producto:");
//     precio = Convert.ToInt32(Console.ReadLine());
//
//     acumulador += precio;
// }
//
// Console.WriteLine($"El total es: {acumulador}");
//====================================================================
// int alumnos = 0;
// double calificacion = 0;
// double promedio = 0;
//
// Console.WriteLine("Digite el numero de alumnos a calificar: ");
// alumnos = Convert.ToInt32(Console.ReadLine());
//
// for (var i = 1; i <= alumnos; i++)
// {
//     Console.WriteLine("Digite la calificacion del alumno: ");
//     calificacion += Convert.ToDouble(Console.ReadLine());
// }
//
// promedio = calificacion / alumnos;
//
// Console.WriteLine($"El promedio general de los estudiantes es de: {promedio}");
//===================================================================

// Console.WriteLine("Ingrese el factorial a calcular:");
// var fact = Convert.ToInt64(Console.ReadLine());
//
// var total = 1;
// for (var i = 1; i <= fact; i++)
// {
//     total *= i;
// }
//
// Console.WriteLine($"El factorial de {fact} es {total}");

//=====================================================================
//=====WHILE=====

// byte numero = 1;
//
// while (numero <= 10)
// {
//     Console.WriteLine(numero);
//     numero++;
// }


// string password1 = "";
// string password2 = "";
//
// Console.WriteLine("Escribe tu contraseña: ");
// password1 = Console.ReadLine();
//
// while (password1 != password2)
// {
//     Console.WriteLine("Confirma tu contraseña: ");
//     password2 = Console.ReadLine();
//
//     if (password1 == password2)
//     {
//         break;
//     }
//     Console.WriteLine("Tus contraseñas no coinciden");
// }
//
// Console.WriteLine("¡Contraseña guardada!");

// int i = 1;
//
// do
// {
//     Console.WriteLine(i);
//     i++;
// }while (i <= 10);


// var num1 = 0;
// var num2 = 0;
// var opcion = 0;
// var resultado = 0;
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
// Console.WriteLine("Escribe el primer numero: ");
// num1 = int.Parse(Console.ReadLine());
//
// Console.WriteLine("Escribe el segundo numero: ");
// num2 = int.Parse(Console.ReadLine());
//
// switch (opcion)
// {
//     case 1:
//         resultado = num1 + num2;
//         break;
//     case 2:
//         resultado = num1 - num2;
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


//=====================================================================
//=====Iteraciones anidadas=====

// int i; //variable se encarga del bucle exterior
// int j; //variable se encargar del bucle interior
// int resultado; //guardar el resultado de la multiplicación
//
// for (i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"Tabla de multiplicar del {i}");
//     for (j = 1; j <= 10; j++)
//     {
//         resultado = i * j;
//
//         Console.WriteLine($"{i} * {j} = {resultado}");
//     }
// }
//
// Console.ReadKey();

//============TAREA 1============
//
// long num = 0;
// long exponente = 0;
//
// double total = 1;
// double totalNegativo = 0;
//
// Console.WriteLine("Introduce un número: ");
// num = Convert.ToInt64(Console.ReadLine());
//
// Console.WriteLine("Introduce la potencia: ");
// exponente = Convert.ToInt64(Console.ReadLine());
//
// if (exponente < 0)
// {
//     exponente *= -1;
//
//     for (var i = 1; i <= exponente; i++)
//     {
//         total *= num;
//     }
//
//     totalNegativo = (1 / total);
//     Console.WriteLine($"El resultado de {num} ^ {exponente * -1} es: {totalNegativo}");
// }
// else
// {
//     for (var i = 1; i <= exponente; i++)
//     {
//         total *= num;
//     }
//     Console.WriteLine($"El resultado de {num} ^ {exponente} es: {total}");
// }
//


//============TAREA 2============

int numero, divisor, numDivisores = 0;

//Bucle exterior
for (numero = 2; numero <= 100; numero++)
{
    for (divisor = 1; divisor <= numero; divisor++)
    {
        if (numero % divisor == 0)
        {
            numDivisores++;
        }
    }

    //verificamos que el número de divisores sea igual a 2
    if (numDivisores == 2)
    {
        Console.WriteLine(numero);
    }
    
    //Reiniciamos el conteo del número de divisores
    numDivisores = 0;
}

Console.ReadKey();