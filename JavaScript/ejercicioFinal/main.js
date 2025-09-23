function agregarTarea() {
    //Obtenemos el valor del campo de la tarea
    let nuevaTareaTexto =
        document.getElementById("nuevaTarea").value; //Obtenemos el valor del  input y no el input como tal

    //Validamos que el valor no este vacio
    if (nuevaTareaTexto === "") {
        alert("Por favor, ingrese una tarea.");
        return;
    }

    //Crear elemento en la lista
    let nuevaTarea = document.createElement("li");

    nuevaTarea.textContent = nuevaTareaTexto + " ";

    //Crear boton Eliminar
    let botonEliminar = document.createElement("button");
    botonEliminar.textContent = "Eliminar";
    botonEliminar.onclick = function () {
        nuevaTarea.remove();
    };

    //Agregar boton Eliminar al elemento de la lista
    nuevaTarea.appendChild(botonEliminar);

    //Agregar el elemento/tarea a la lista
    document.getElementById("listaTareas").appendChild(nuevaTarea);

    //Limpiar el cuadro de texto del nombre de la tarea
    document.getElementById("nuevaTarea").value = "";
}
