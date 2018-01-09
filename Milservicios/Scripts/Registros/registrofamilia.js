/*CONTROL DEL REGISTRO FAMILIA*/

//Funcion de comienzo
function comienzo() {
    //Recogemos la informacion
    var nombre = document.getElementById("RF-NombreC");
    var apellido = document.getElementById("RF-ApellidoC");
    var telefono = document.getElementById("RF-TelefonoC");
    var email = document.getElementById("RF-EmailC");
    var contraseña = document.getElementById("RF-PasswordC");
    var ciudad = document.getElementById("RF-CiudadC");
    //Validamos los textos recogidos
    nombre.addEventListener("input", validar_nombre, false);
    apellido.addEventListener("input", validar_apellido, false);
    telefono.addEventListener("input", validar_telefono, false);
    email.addEventListener("input", validar_email, false);
    contraseña.addEventListener("input", validar_contraseña, false);
    ciudad.addEventListener("input", validar_ciudad, false);
    validar_nombre();
    validar_apellido();
    validar_telefono();
    validar_email();
    validar_contraseña();
    validar_ciudad();
}
//Validaciones
function validar_nombre() {
    if (nombre.value == "") {
        nombre.setCustomValidity("Introduce el nombre para registrar");
        nombre.style.background = "#f06161";
    }
    else {
        nombre.setCustomValidity(""); 
        nombre.style.background = "#ffffff";
    }
}
function validar_apellido() {
    if (apellido.value == "") {
        apellido.setCustomValidity("Introduce el apellido para registrar");
        apellido.style.background = "#f06161";
    }
    else {
        apellido.setCustomValidity("");
        apellido.style.background = "#ffffff";
    }
}
function validar_telefono() {
    if (telefono.value == "") {
        telefono.setCustomValidity("Introduce el telefono para registrar");
        telefono.style.background = "#f06161";
    }
    else {
        telefono.setCustomValidity("");
        telefono.style.background = "#ffffff";
    }
}
function validar_email() {
    if (email.value == "") {
        email.setCustomValidity("Introduce el email para registrar");
        email.style.background = "#f06161";
    }
    else {
        email.setCustomValidity("");
        email.style.background = "#ffffff";
    }
}
function validar_contraseña() {
    if (contraseña.value == "") {
        contraseña.setCustomValidity("Introduce la contraseña para registrar");
        contraseña.style.background = "#f06161";
    }
    else {
        contraseña.setCustomValidity("");
        contraseña.style.background = "#ffffff";
    }
}
function validar_ciudad() {
    if (ciudad.value == "") {
        ciudad.setCustomValidity("Introduce la ciudad para registrar");
        ciudad.style.background = "#f06161";
    }
    else {
        ciudad.setCustomValidity("");
        ciudad.style.background = "#ffffff";
    }
}
