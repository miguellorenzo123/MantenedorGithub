using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MantenedorGithub
{
    class Conexion
    {
                 /// <summary> !!!! CAMBIAR CADA VEZ QUE ACTUALIZEN EL REPOSITORIO DE GITHUB
         /// ---Dara Sourece = Nombre de Servidor SQL; DATABASE= Nombre de base a utilizar
                 /// </summary>
        string cadena = "Data Source=DESKTOP-CVMHKR2 ; DATABASE=PruebaGitHub ; Integrated security=true";
        public SqlConnection conectarBD = new SqlConnection();
       
        
        public Conexion()
        {
            conectarBD.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarBD.Open();
                Console.WriteLine("Conexion Abierta.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);
            }
        }

        public void cerrar()
        {
            conectarBD.Close();
        }
    }

}
