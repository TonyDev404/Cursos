// function saludar() {
//     console.log("Hola! Estoy en la función");
// }

// saludar();

// function sumar(num1, num2) {
//     return num1 + num2;
// }

// let suma = sumar(5, 10);
// console.log("El resultado es: " + suma);

// suma = sumar(8, 9);
// console.log("El resultado es: " + suma);

//===========Ejercicio integrador Pokémon===========

//Array para los nombres
var pokemones = ["Charmander", "Pikachu", "Bulbasaur", "Squirtle"];

//Matriz para sus habilidades
var habilidades = [
    [80, 75, 90], //Charmander
    [65, 55, 60], //Pikachu
    [80, 70, 65], //Bulbasaur
    [85, 90, 70] //Squirtle
]

function calcularPromedio(habilidades) {
    let promedios = [];

    for(var i = 0; i < habilidades.length; i++) {
        let fila = habilidades[i];
        let suma = fila.reduce((total, habilidad) => total + habilidad, 0);
        //por cada fila, se calcula el total llamando a cada elemento de la fila "habilidad" y se suman los elementos empezando desde el indice 0

        promedios[i] = suma / fila.length;
    }

    return promedios;
}

function evaluarAptitud(nombres, promedios) {
    
    for(var i = 0; i < promedios.length; i++) {
        if(promedios[i] >= 70) {
            console.log(`El Pokemon ${nombres[i]} supera el promedio con: ${promedios[i]}`);
        }
        else {
            console.log(`El Pokemon ${nombres[i]} no supera el promedio con: ${promedios[i]}`)
        }
    }
}

let promedios = calcularPromedio(habilidades);
evaluarAptitud(pokemones, promedios);

function funcionPrueba() {
    console.log("Hola mundo");
}