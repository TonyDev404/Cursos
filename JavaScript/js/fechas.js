// //AAAA-MM-DD HH:MM:SS
// var fecha = new Date();
// var fechaEsp = new Date(1991, 10, 23);
// var fechaPersonalizada = new Date("05/25/2023");


// //Special Functions
// var day = fecha.getDate();
// var month = fecha.getMonth();
// var year = fecha.getFullYear();

// // alert("La fecha de hoy es: " + fecha);
// // alert("La fecha de hoy es: " + fechaEsp);
// // alert("La fecha de hoy es: " + fechaPersonalizada);
// alert(`Day: ${day} Mes: ${month + 1} Anio: ${year}`); //mes le aumentamos 1 porque empieza desde 0


//===================Ejercicio practico ===================
//Ingresar una fecha mediante un prompt y mostrar mediante un alert a que dia de la semana corresponde

var fechaIngreso = window.prompt("Ingrese una fecha en formato mm/dd/aaaa");

var fecha = new Date(fechaIngreso);
var dia = fecha.getDay();

switch(dia){
    case 0:
        dia = "Domingo";
        break;
    case 1:
        dia = "Lunes";
        break;
    case 2:
        dia = "Martes";
        break;
    case 3:
        dia = "Miercoles";
        break;
    case 4:
        dia = "Jueves";
        break;
    case 5:
        dia = "Viernes";
        break;
    case 6:
        dia = "Sabado";
        break;
}

alert(`El dia de la semana es: ${dia}`);