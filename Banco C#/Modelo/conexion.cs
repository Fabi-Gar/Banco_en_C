using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_C_.Modelo
{
    internal class conexion
    {
        public static class Miconexion
        {
            public static SqlConnection conexion;

            public static String user;
            public static String pass;


            public static void abrir_conexion()
            {
                conexion = new SqlConnection("Data Source=FABIPC\\SQLEXPRESS;Initial Catalog=Banco;Persist Security Info=True;User ID=" + user + ";Password=" + pass + ";TrustServerCertificate=True");

                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }


            public static System.Data.ConnectionState ObtenerEstadoConexion()
            {
                return conexion.State;
            }
        }
    }
}
