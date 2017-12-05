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
        //Registro de usuarios
        /* VIEJO METODO
        public void RegistroFamilia(string nombre, string apellido, int telefono, string email, string contraseña)
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
        */
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
            usuario.PROFESIONAL.Sexo = sexo;
            usuario.PROFESIONAL.Edad = edad;
            usuario.PROFESIONAL.Descripcion = descripcion;
            usuario.PROFESIONAL.Zona = zona;
            usuario.PROFESIONAL.ANUNCIO = null;           
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
            usuario.FAMILIA.Ciudad = ciudad;
            usuario.PROFESIONAL.ANUNCIO = null;
            usuario.PROFESIONAL.Sexo = sexo;
            usuario.PROFESIONAL.Edad = edad;
            usuario.PROFESIONAL.Descripcion = descripcion;
            usuario.PROFESIONAL.Zona = zona;
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

    }
}