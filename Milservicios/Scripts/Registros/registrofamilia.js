/*CONTROL DEL REGISTRO FAMILIA*/

//Validaciones
function validar_nombre() { }



//Funcion de comienzo
function start_page() {
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
}

window.addEventListener("load", start_page(), false);