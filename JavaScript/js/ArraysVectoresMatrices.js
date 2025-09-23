// let miVector = [1, 2, 3, 4, 5];

// console.log(miVector);
// console.log(miVector[2]);

// let miMatriz = [
//     [1,2,3],
//     [4,5,6],
//     [7,8,9]
// ];

// console.log(miMatriz);
// console.log(miMatriz[1][1]);
// let miVector = ["Antonio", "Ibra", "Pepe", "hola", "bye"];
// console.log(miVector[2]);
//=============================================================


// let vector = new Array(3);
// vector[0] = "Antonio";
// vector[1] = "Tony";

// let matriz = new Array(3);

// for(var i = 0; i < 3; i++) {
//     matriz[i] = new Array(3);
// }
// ;
// console.log(matriz)
//=============================================================

// let persona0 = ["Antonio", "Narvaez", "Guzman"];
// let persona1 = ["Suscribite", "a", "TodoCode"];
// let persona2 = ["Cleo", "The", "Dog"];

// let matriz = [persona0, persona1, persona2];

// console.log(matriz);
//=============================================================

// let paisesLatam = ["Argentina", "Mexico", "Colombia", "Brasil"];

// for(var i = 0; i < paisesLatam.length; i++) {
//     console.log(paisesLatam[i]);

//     if(paisesLatam[i] == "Mexico") {
//         console.log("Estoy en el país de México");
//     }
// }

// let paisesLatam = [
//     ["Argentina", "México", "Colombia", "Brasil"],
//     ["Chile", "Perú", "Venezuela", "Uruguay"],
//     ["Ecuador", "El Salvador","Bolivia", "Paraguay"]
// ]

// for(var i = 0; i < paisesLatam.length; i++) {
//     for(var j = 0; j < paisesLatam[i].length; j++) {
//         console.log(paisesLatam[i][j]);
//     }
// }
//=============================================================

// let frutas = ["naranja", "banana", "kiwi"];
// let frutas2 = ["manzana", "mango"];
// frutas.push("uva");
// console.log(frutas);

// // frutas.pop(); //borra el ultimo
// // frutas.shift(); //elimina el primer elemento
// frutas.unshift("sandía"); //agrega al inicio
// console.log(frutas);

// let frutasConA = frutas.filter(fruta => fruta.includes("a")); 
// //filtrar elementos que contengan la letra "a"
// console.log(frutasConA);


// let todasLasFrutas = frutas.concat(frutas2); //unir dos arrays

// todasLasFrutas.sort(); //ordenar alfabeticamente
// console.log(todasLasFrutas)