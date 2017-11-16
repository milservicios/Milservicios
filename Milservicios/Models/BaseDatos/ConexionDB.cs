using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Milservicios.Models.ConexionDB
{
    public class ConexionDB
    {
        string cadena = "Data Source = milserviciosserver.database.windows.net; Initial Catalog = MilserviciosDB; Persist Security Info=True;";
        public SqlConnection conectar = new SqlConnection();

        public ConexionDB()
        {
            conectar.ConnectionString = cadena;
        }
        //Abrimos la conexion a la base de datos
        public void abrir()
        {
            try
            {
                conectar.Open();
            }
            catch (Exception excp)
            {
                Console.WriteLine("ERROR EN BASE DE DATOS: " + excp.Message);
            }
        }
        //Cerramos la conexion a la base de datos
        public void cerrar()
        {
            try
            {
                conectar.Close();
            }
            catch (Exception excp)
            {
                Console.WriteLine("ERROR EN EL CIERRE: " + excp.Message);
            }
        }
    }
}
    //User ID = MilserviciosAdmin; Password=***********