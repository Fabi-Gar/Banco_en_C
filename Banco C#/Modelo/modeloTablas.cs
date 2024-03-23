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
    internal class modeloTablas
    {
        public DataTable TablaCuentas()
        {
            DataTable tablaCuentas = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ObtenerDatosCuentas";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaCuentas);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaCuentas;

        }

        public DataTable TablaDepositos(string numCuenta)
        {
            DataTable tablaDepositos = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarDeposito";
                cmd.Parameters.AddWithValue("idCuenta", numCuenta);
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tablaDepositos);

                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaDepositos;
        }
    }
}
