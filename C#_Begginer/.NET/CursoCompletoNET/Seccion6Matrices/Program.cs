//tipo[] nombre = new tipo[size];

// double[] calificaciones = new double[4]; //declaracion de una matriz de tipo "double"
//
// string[] nombres= new string[5];
// int[] numeros = new int[10];
// byte[] datos = new byte[7];
//===================================================================================
// //double[] calificaciones = new double[4] {9, 10, 7.4, 6};
// double[] calificaciones = {9, 10, 7.4, 6};
//
// //declaracion de una matriz
// int[] numeros;
//
// //instancia (creacion del objeto) e inicilizacion
// numeros = new int[] {5, 3, 1};
//===================================================================================

// double[] calificaciones = new double[4];
//
// //asignandole un valor de 7.4 al tercer elemento de la matriz
// calificaciones[0] = 9;
// calificaciones[1] = 10;
// calificaciones[2] = 7.4;
// calificaciones[3] = 6;
//===================================================================================

// string[] nombres = new string[3];
//
// //coloamos valores en los tres elementos
// nombres[0] = "Sandra";
// nombres[1] = "Pedro";
// nombres[2] = "Carmen";
//
// byte i; //variable de control del ciclo
//
// for (i = 0; i <= 2; i++)
// {
//     Console.WriteLine(nombres[i]);
// }
//===================================================================================

// string[] nombres = new string[3];
//
// for (var i = 0; i <= 2; i++)
// {
//     Console.WriteLine($"Ingresa el valor para el indice {i}: ");
//     nombres[i] = Console.ReadLine();
// }
//
// //mostramos los valores
// for (var i = 0; i <= 2; i++)
// {
//     Console.WriteLine($"nombre {i + 1}: {nombres[i]}");
// }
//===================================================================================
//======Ejercicio 1======

// var alumnos = 0;
// Console.WriteLine("Ingrese el numero de alumnos");
// alumnos = int.Parse(Console.ReadLine());
//
// var calificaciones = new double[alumnos];
//
// for (int i = 0; i < alumnos; i++)
// {
//     Console.WriteLine("Ingrese la calificacion del alumno: ");
//     calificaciones[i] = double.Parse(Console.ReadLine() ?? string.Empty);
// }
//
// double count = 0;
// for (int i = 0; i < calificaciones.Length; i++)
// {
//     count += calificaciones[i];
// }
//
// var promedio = count / alumnos;
// var maxValue  = calificaciones.Max();
// var minValue = calificaciones.Min();
//
// Console.WriteLine($"Promedio de calificaciones: {promedio}");
// Console.WriteLine($"La calificacion mas alta es: {maxValue}");
// Console.WriteLine($"La calificacion mas baja es: {minValue}");

//===================================================================================
//======Matrices multidimensionales======

//tipo[,] nombre = new tipo [filas, columnas]
double[,] ventas = new double[4,3];

//declaracion e instancia de matriz de tres dimensiones
double[,,] ventasAnio = new double[5, 3, 3];