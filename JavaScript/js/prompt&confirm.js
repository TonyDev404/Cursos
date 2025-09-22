//Prompt
//===============================================================
//Lo primero es lo que queremos que aparezca como mensaje y lo segundo es la respusesta predeterminada

// var respuesta = window.prompt("Ya te suscribiste a mi canal ?", "Si, ya estoy suscrito");

// alert ("Su respuesta fue: " + respuesta);

//Confirm
//===============================================================
// var confirmacion = window.confirm(
//     "Quiere suscribirse al canal de TodoCode?"
// );

// if (confirmacion) {
//     alert("Muchas gracias por suscribirte, sos un crack! 💪");
// }
// else {
//     alert("PIPIPIPI 😭😭😭")
// }

//===================Ejercicio practico ===================
var value1 = parseInt(window.prompt("Ingrese un valor")); 
//se parsea por que prompt por defecto devuelve un string
var value2 = parseInt(window.prompt("Ingrese el segundo valor"));

if(value1 > value2) {
    alert(`${value1} es mayor que ${value2}`);
} 
else if (value2 > value1) {
    alert(`${value2} es mayor que ${value1}`);
}