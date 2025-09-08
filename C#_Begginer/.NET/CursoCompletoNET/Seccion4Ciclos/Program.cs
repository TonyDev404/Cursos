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

