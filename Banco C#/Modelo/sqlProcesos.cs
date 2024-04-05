using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banco_C_.Modelo.conexion;
using System.Windows.Forms;

namespace Banco_C_.Modelo
{
    internal class sqlProcesos
    {
        public static void agregarCuenta(string dato1, string dato2, string dato3)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altaCuentas";
                cmd.Connection = Miconexion.conexion;

                cmd.Parameters.Add(new SqlParameter("@dato1", dato1));
                cmd.Parameters.Add(new SqlParameter("@dato2", dato2));
                cmd.Parameters.Add(new SqlParameter("@dato3", dato3));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado exitosamente");
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salio mal " + ex.Message);
            }
        }

        public static void realizarDeposito(string dato1, date dato2, string dato3)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Depositar";
                cmd.Connection = Miconexion.conexion;

                cmd.Parameters.Add(new SqlParameter("@numCuenta", dato1));
                cmd.Parameters.Add(new SqlParameter("@fechaDeposito", dato2));
                cmd.Parameters.Add(new SqlParameter("@cantidad", dato3));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado exitosamente");
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salio mal " + ex.Message);
            }
        }
    }
}

