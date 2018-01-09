using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Milservicios.Models.TablasSQL;
using System.Data.SqlClient;
using Milservicios.Models.BaseDatos;

namespace Milservicios.Models.BaseDatos
{
    public class BaseDatos
    {
        MilserviciosDBEntities database = new MilserviciosDBEntities();
        bool seguir = true;     
        //Acceso de usuarios
        public bool AccesoUsuario(string email, string contraseña)
        {
            bool validacion = false;
            USUARIO user = new USUARIO();
            int count = database.USUARIO.Count();
            while (seguir && count > 0)
            {
                //Comprobamos que nuestra tabla no esta vacia
                if (database.USUARIO != null ) { user = database.USUARIO.ElementAt(count); }
                else { seguir = false; }
                //Comprabamos si coinciden con los datos de nuestra base de datos de azure    
                if (user.Email.Equals(email))
                {
                    if (user.Contraseña.Equals(contraseña))
                    {
                        validacion = true;
                        break;
                    }
                }
                else
                {
                    count--;
                }
            }
            return validacion;
        }
        /*NUEVO MODELO DE REGISTRO DE USUARIOS POR TIPOS*/
        //Registro Familia
        public void RegistroFamilia(string nombre,
            string apellido,
            int telefono, 
            string email, 
            string contraseña,
            string ciudad)
        {
            //Creamos una instancia de usuario
            USUARIO usuario = new USUARIO();            
            //Rellenamos el usuario creado           
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Telefono = telefono;
            usuario.Email = email;
            usuario.Contraseña = contraseña;
            usuario.FAMILIA = new FAMILIA();
            usuario.FAMILIA.Ciudad = ciudad;
            usuario.FAMILIA.ANUNCIO = null;
            usuario.PROFESIONAL = null;
            //Añadimos a la base de datos el objeto usuario
            database.USUARIO.Add(usuario);
            //Guardamos los cambios
            try
            {
                database.SaveChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
        //Registro Profesional
        public void RegistroProfesional(string nombre,
            string apellido,
            int telefono,
            string email, 
            string contraseña,
            string sexo,
            short edad,
            string descripcion,
            string zona)
        {
            //Creamos una instancia de usuario
            USUARIO usuario = new USUARIO();
            //Rellenamos el usuario creado           
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Telefono = telefono;
            usuario.Email = email;
            usuario.Contraseña = contraseña;
            usuario.FAMILIA = null;
            usuario.PROFESIONAL = new PROFESIONAL();
            usuario.PROFESIONAL.Sexo = sexo;
            usuario.PROFESIONAL.Edad = edad;
            usuario.PROFESIONAL.Descripcion = descripcion;
            usuario.PROFESIONAL.Zona = zona;
            usuario.PROFESIONAL.ANUNCIO = null;
            usuario.PROFESIONAL.Foto = null;
            usuario.PROFESIONAL.Curriculum = null;
            //Añadimos a la base de datos el objeto usuario
            database.USUARIO.Add(usuario);
            //Guardamos los cambios
            try
            {
                database.SaveChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
        //Registro Ambos
        public void RegistroAmbos(string nombre,
            string apellido,
            int telefono, 
            string email, 
            string contraseña,
            string ciudad,
            string sexo,
            short edad,
            string descripcion,
            string zona)
        {
            //Creamos una instancia de usuario
            USUARIO usuario = new USUARIO();
            //Rellenamos el usuario creado           
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Telefono = telefono;
            usuario.Email = email;
            usuario.Contraseña = contraseña;
            usuario.FAMILIA.ANUNCIO = null;
            usuario.FAMILIA = new FAMILIA();
            usuario.FAMILIA.Ciudad = ciudad;
            usuario.PROFESIONAL = new PROFESIONAL();
            usuario.PROFESIONAL.ANUNCIO = null;            
            usuario.PROFESIONAL.Sexo = sexo;
            usuario.PROFESIONAL.Edad = edad;
            usuario.PROFESIONAL.Descripcion = descripcion;
            usuario.PROFESIONAL.Zona = zona;
            usuario.PROFESIONAL.Foto = null;
            usuario.PROFESIONAL.Curriculum = null;
            //Añadimos a la base de datos el objeto usuario
            database.USUARIO.Add(usuario);
            //Guardamos los cambios
            try
            {
                database.SaveChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
        //--------------------------------------------Registro de anuncios-------------------------------------------------------
        public void RegistroAnunciosClasePart(int duracion,
            string horario,
            string nacionalidad,
            bool carnet,
            double sueldo,
            string zona,
            bool fumador,
            string asignatura,
            string curso,
            string tipo,
            string lugar)
        {
            //Creamos una instancia de anuncio
            ANUNCIO anuncio = new ANUNCIO();
            CLASE_PART clasePart = new CLASE_PART();
            //Rellenamos el anuncio creado           
            anuncio.Duracion = duracion;
            anuncio.Horario = horario;
            anuncio.Nacionalidad = nacionalidad;
            anuncio.Carnet = carnet;
            anuncio.Sueldo = sueldo;
            anuncio.Zona = zona;
            anuncio.Fumador = fumador;
            clasePart.Asignatura = asignatura;
            clasePart.Curso = curso;
            clasePart.Tipo = tipo;
            clasePart.Lugar = lugar;
            anuncio.CLASE_PART.Add(clasePart);
            //Añadimos a la base de datos el objeto anuncio
            database.ANUNCIO.Add(anuncio);
            //Guardamos los cambios
            try
            {
                database.SaveChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
        //--------------------------------------------
        public void RegistroAnunciosCudadoMasc(int duracion,
            string horario,
            string nacionalidad,
            bool carnet,
            double sueldo,
            string zona,
            bool fumador,
            string animal,
            short numero)
        {
            //Creamos una instancia de anuncio CUIDADO DE MASCOTAS
            ANUNCIO anuncio = new ANUNCIO();
            CUIDADO_MASC cuidadoMasc = new CUIDADO_MASC();
            //Rellenamos el anuncio creado           
            anuncio.Duracion = duracion;
            anuncio.Horario = horario;
            anuncio.Nacionalidad = nacionalidad;
            anuncio.Carnet = carnet;
            anuncio.Sueldo = sueldo;
            anuncio.Zona = zona;
            anuncio.Fumador = fumador;
            cuidadoMasc.Animal = animal;
            cuidadoMasc.Numero = numero;
            anuncio.CUIDADO_MASC.Add(cuidadoMasc);
            //Añadimos a la base de datos el objeto anuncio
            database.ANUNCIO.Add(anuncio);
            //Guardamos los cambios
            try
            {
                database.SaveChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
        //--------------------------------------
        public void RegistroAnunciosCudadoPers(int duracion,
            string horario,
            string nacionalidad,
            bool carnet,
            double sueldo,
            string zona,
            bool fumador,
            short edad,
            short numero,
            string tipo)
        {
            //Creamos una instancia de anuncio CUIDADO DE PERSONAS
            ANUNCIO anuncio = new ANUNCIO();
            CUIDADO_PERS cuidadoPers = new CUIDADO_PERS();
            //Rellenamos el anuncio creado           
            anuncio.Duracion = duracion;
            anuncio.Horario = horario;
            anuncio.Nacionalidad = nacionalidad;
            anuncio.Carnet = carnet;
            anuncio.Sueldo = sueldo;
            anuncio.Zona = zona;
            anuncio.Fumador = fumador;
            cuidadoPers.Edad = edad;
            cuidadoPers.Numero = numero;
            cuidadoPers.Tipo = tipo;
            anuncio.CUIDADO_PERS.Add(cuidadoPers);
            //Añadimos a la base de datos el objeto anuncio
            database.ANUNCIO.Add(anuncio);
            //Guardamos los cambios
            try
            {
                database.SaveChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
        public void RegistroAnunciosLaborDom(int duracion,
            string horario,
            string nacionalidad,
            bool carnet,
            double sueldo,
            string zona,
            bool fumador,
            string tarea)
        {
            //Creamos una instancia de anuncio LABORES DOMESTICAS
            ANUNCIO anuncio = new ANUNCIO();
            LABOR_DOM laborDom = new LABOR_DOM();
            //Rellenamos el anuncio creado           
            anuncio.Duracion = duracion;
            anuncio.Horario = horario;
            anuncio.Nacionalidad = nacionalidad;
            anuncio.Carnet = carnet;
            anuncio.Sueldo = sueldo;
            anuncio.Zona = zona;
            anuncio.Fumador = fumador;
            laborDom.Tarea = tarea;
            anuncio.LABOR_DOM.Add(laborDom);
            //Añadimos a la base de datos el objeto anuncio
            database.ANUNCIO.Add(anuncio);
            //Guardamos los cambios
            try
            {
                database.SaveChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }





    }   
}