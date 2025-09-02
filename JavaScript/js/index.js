// alert("Hola mundo con JavaScript");

//Declaracion y asignacion de variables
// var nombre = "Antonio";
// var edad = "23";
// var presenteONo = true;
// var apellido = "Narvaez";
// var estatura = 1.70

// console.log("Nombre: ", nombre + " " + typeof(nombre));
// console.log("Edad: ", edad+ " " + typeof(edad));
// console.log("Presente: ", presenteONo + " " + typeof(presenteONo));
// console.log("Apellido: ", apellido + " " + typeof(apellido));
// console.log("Estatura: ", estatura + " " + typeof(estatura));
//=====================================================================
//Ejercicio integrador
// var cuentaTotal = 0;

// var comida = 2800+1300;
// var bebida = 900 + 650;

// var cuentaTotal = comida + bebida;

// console.log(`El total de la comida fue de: ${comida}`);
// console.log(`El total de las bebidas fue de: ${bebida}`);
// console.log(`El total de la cuenta fue de: ${cuentaTotal}`);
//=====================================================================
//Estructuras Condicionales
// var aprobe = true;

// if(aprobe == true) {
//     console.log("Puedo salir!!");
// }
// else {
//     console.log("Tengo que estudiar mirando videos de TodoCode");
// }
//=====================================================================
//Condicional Switch

// var color = prompt("Escrbe un color primario");
// //promt sirve para pedir datos al usuario

// switch (color) {
//     case "rojo":
//         console.log("Color rojo");
//         break;
//     case "azul":
//         console.log("Color azul");
//         break;
//     case "amarillo":
//         console.log("Color amarillo");
//         break;
//     default:
//         console.log(
//             "Ingresa un color valido como rojo, azul o amarillo"
//         );
//         break;
// }
//=====================================================================
//Ejercicio integrador 2
// var num1 = prompt("Escribe un numero");
// var num2 = prompt("Escribe otro numero");

// var resta = num1 - num2;

// if(resta > 0) {
//     console.log("Es mayor a cero");
//     if(resta % 2 == 0) {
//         console.log("Es par");
//     }
//     else {
//         console.log("Es impar");
//     }
// }
// else {
//     console.log("Es menor o igual a cero");
// }
//=====================================================================
//Estructuras repetitivas

//While
// var contador = 0;

// while(contador < 10) { //Siempre es menor que el numero que le digamos
//     console.log("Estoy en la vuelta N°: " + contador);
//     contador ++;
// }

//For
/*Si empieza en 0 sera menor a n, si empiza en 1 sera menor igual a n*/

// for (var i = 1; i < 10; i++) { 
//     console.log("Vuelta N°:" + i);
// }

//Do While
// var contador = 0;
// do {
//     console.log("Vuelta N° " + contador);
//     contador++;
// }
// while(contador <= 10)

/*La  diferencia entr while y do while es que el do while se ejecuta al menos una vez y luego hace la comparacion, mientras que en el while primero hace la comparacion y luego se ejecuta*/