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

// //tipo[,] nombre = new tipo [filas, columnas]
// double[,] ventas = new double[4,3]
// {
//     {100, 120, 205},
//     {115, 196, 300},
//     {157, 172, 245},
//     {130, 180, 281}
// };
//
// // //declaracion e instancia de matriz de tres dimensiones [filas, columnas, profundidad]
// int [,,] matriz3D = new int[2,2,3]
// {
//     {
//         {1, 2, 3}, 
//         {4, 5, 6}
//     },
//     {
//         {7, 8, 9}, 
//         {10, 11, 12}
//     }
// };
//

// double[,] ventas = new double [4, 3]
// {
//     {100, 120, 205},
//     {115, 196, 300},
//     {157, 172, 245},
//     {130, 180, 281}
// };
//
// for (var i = 0; i < 4; i++)
// {
//     Console.WriteLine($"Fila {i}");
//     for (var j = 0; j < 3; j++)
//     {
//         Console.WriteLine(ventas[i, j]);
//     }
// }

// Console.WriteLine(ventas[3, 2]);
// ventas[1, 2] = 450;

//===================================================================================
//======Ejercicio 1======
//
// byte alumnos, salones;
// var sumaCalif = 0.00;
// var califMin = 0.00;
// var califMax = 0.00;
// double promedio;
//
// //Pedimos el número de salones
// Console.WriteLine("Ingrese el número de salones: ");
// salones = Convert.ToByte(Console.ReadLine());
//
// //Pedimos el número de alumnos
// Console.WriteLine("Ingrese el número de alumnos por salón: ");
// alumnos = Convert.ToByte(Console.ReadLine());
//
// //Creación de la matriz
//  double[,] calificaciones = new double[salones, alumnos];
//
//  for (var i = 0; i < salones; i++)
//  {
//      Console.WriteLine($"Salón {i}");
//      for (var j = 0; j < alumnos; j++)
//      {
//          //Pedimos la califiación
//          Console.WriteLine($"Ingresa la calificación del alumno {j}: ");
//          calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());
//          
//          //Acumulamos las calificaciones
//          sumaCalif += calificaciones[i,j];
//      }
//  }
//  
//  //Calculamos el promedio
//  promedio = sumaCalif / (salones * alumnos);
//  
//  //Calculamos la calificación mínima
//  
//  for (var i = 0; i < salones; i++)
//  {
//      for (var j = 0; j < alumnos; j++)
//      {
//          if (calificaciones[i, j] < califMin)
//          {
//              califMin = calificaciones[i, j];
//          }
//      }
//  }
//  
//  //Calculamos la calificación máxima
//  for (var i = 0; i < salones; i++)
//  {
//      for (var j = 0; j < alumnos; j++)
//      {
//          if (calificaciones[i, j] > califMin)
//          {
//              califMin = calificaciones[i, j];
//          }
//      }
//  }
//
//  Console.WriteLine("\n");
//  Console.WriteLine($"El promedio es {promedio:F2}");
//  Console.WriteLine($"La calificación mínima es: {califMin}");
//  Console.WriteLine($"La calificación máxima es: {califMax}");

//===================================================================================
//======Matrices escalonadas======

// double[][] ventas = new double [4][];
//
// //declaracion de las matrices internas e inicializacion
// ventas[0] = [155, 100, 170]; //también se puede hacer asi
// ventas[1] = new double[2] {205, 120};
// ventas[2] = new double[4] {115, 190, 104, 130};
// ventas[3] = new double[3] {163, 218, 125};

//Lo mismo de arriba pero mas limpio
// var ventas = new double[][]
// {
//     [155, 100, 170],
//     [205, 120],
//     [115, 190, 104, 130],
//     [163, 218, 125]
// };
//
// for (var i = 0; i < ventas.Length; i++)
// {
//     Console.WriteLine($"Elemento: {i}");
//     
//     for (var j = 0; j < ventas[i].Length; j++)
//     {
//         Console.WriteLine(ventas[i][j]);
//     }
// }

//======Matrices escalonadas Ejercicio======

// byte numAlumnos, salones;
// double promedio, sumaAlumnos = 0, sumaCalif = 0, califMin = 10, califMax = 0;
//
// // pedimos el numero de salones
// Console.WriteLine("Ingrese el número de salones: ");
// salones = Convert.ToByte(Console.ReadLine());
//
// //creación de la matriz
//  double[][] calificaciones = new double[salones][];
//
// //pedimo el número de alumnos por salón
//  for (var i = 0; i < salones; i++)
//  {
//      Console.WriteLine($"Ingrese el número de alumnos para el salón {i + 1}: ");
//      numAlumnos = Convert.ToByte(Console.ReadLine());
//
//      //acumulamos el número de alumnos totales, para el promedio de toda la escuela
//      sumaAlumnos += numAlumnos;
//      
//      //instanciamos las matrices internas (alumnos en cada salón)
//      calificaciones[i] = new double[numAlumnos];
//  }
//  
//  //pedimos las calificaciones de los alumnos de cada salón
//  for (var i = 0; i < salones; i++)
//  {
//      for (int j = 0; j < calificaciones[i].Length; j++)
//      {
//          Console.WriteLine($"Ingresa la calificación del alumno {j + 1}: ");
//          calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());
//          
//          sumaCalif += calificaciones[i][j];
//      }
//  }
//  
// //calculamos el promedio
//  promedio = sumaCalif / sumaAlumnos;
//
// //calculamos la calificación mínima
//  for (var i = 0; i < salones; i++)
//  {
//      for (var j = 0; j < calificaciones[i].Length; j++)
//      {
//          if (calificaciones[i][j] < califMin)
//          {
//              califMin = calificaciones[i][j];
//          }
//      }
//  }
//  
//  //calculamos la calificación máxima
//  for (var i = 0; i < salones; i++)
//  {
//      for (var j = 0; j < calificaciones[i].Length; j++)
//      {
//          if (calificaciones[i][j] > califMax)
//          {
//              califMax = calificaciones[i][j];
//          }
//      }
//  }
//  
//  //mostramos las calificaciones de todos los alumnos de la escuela
//  for (var i = 0; i < salones; i++)
//  {
//      for (var j = 0; j < calificaciones[i].Length; j++)
//      {
//          Console.WriteLine($"El alumno {j + 1}, tiene {calificaciones[i][j]} de calificación");
//      }
//  }
//
//  Console.WriteLine($"El promedio es: {promedio}");
//  Console.WriteLine($"La calificaicón mínima es: {califMin}");
//  Console.WriteLine($"La calificación máxima es: {califMax}");


double[,] ventas2D = new double[4, 3]
{
    { 100, 120, 205 },
    { 115, 196, 300 },
    { 157, 172, 245 },
    { 130, 180, 281 }
};

//Mostramos el tamaño de la primera dimensión
Console.WriteLine(ventas2D.GetLength(1));

for (var i = 0; i < ventas2D.GetLength(1); i++)
{
    Console.WriteLine($"Flia {i}");

    for (var j = 0; j < ventas2D.GetLength(1); j++)
    {
        Console.WriteLine(ventas2D[i, j]);
    }
}