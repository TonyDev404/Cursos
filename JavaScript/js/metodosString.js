// let frase = "Sucribite a TodoCode";
// let longitud = frase.length;
// let fragmento = frase.slice(0, 10); 
// //El ultimo numero debe ser el caracter siguiente al ultimo que se quiere recortar

// console.log("La longitud es: " + longitud);
// console.log(fragmento);


// let frutas = "naranja, manzana, lechuga, tomate";
// console.log("Frase original: " + frutas);
// let lista = frutas.split(",");
// console.log(lista);


// //substring solo es para cadenas de caracteres mientras que slice e para arrays y cadenas
// let subcadena = frase.substring(0, 10);
// console.log(subcadena);

// let mayus = frase.toUpperCase();
// let minus = frase.toLowerCase();

// let frase1 = "Hola ";
// let frase2 = "Mundo";

// let mensajeFinal = frase1.concat(frase2);
// console.log(mensajeFinal);

// let posicion = frase.indexOf("TodoCode");
// //Es case sensitive, devuelve -1 si no lo encuentra

// if (posicion >= 0) {
//     console.log("Encontre en la posicion: " + posicion);
// }
// else {
//     console.log("No encotre la palabra a buscar");
// }


// let bandera = frase.includes("todocode");

// if(bandera == true) {
//     console.log("Encontre la palabra");
// } 
// else {
//     console.log("No encontra la palabra buscada")
// }


//=====Ejercicio Integrador=====
//Mi solucion
/*
var nombres = [
    "Juan",
    "Antonio",
    "Ana"
]

let nombre = window.prompt("Ingrese su nombre: ");

if(nombres.includes(nombre)) {
    alert("El nombre ya existe...");
}
else {
    nombres.push(nombre);
    alert("Su nombre a sido agregado con exito!");
    console.log(nombres);
}
*/

//=================================
// Solucion del profesor
function buscarNombre (listaNombres, nombreBuscar) {
    return listaNombres.includes(nombreBuscar);
}

//lista de nombres 
let listaNombres = [
    "Juan",
    "Antonio",
    "Ana"
]

//Usuario puede ingresar un nombre por teclado
let nombreBuscar = prompt("Ingrese el nombre a buscar: ");

//Buscar si esta o no
let estaONo = buscarNombre(listaNombres, nombreBuscar);

//Informar por pantalla
if (estaONo) {
    console.log("EL nombre esta en la lista");
}
else {
    console.log("El nombre no esta en la lista");
}