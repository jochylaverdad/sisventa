using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDato
{
    class Conexion
    {
        private static string dataSoure = "DESKTOP-07RQMUT";
        private static string initialCatalog = "dbventas";

        public static string ConnectionString = $"Data Source={dataSoure};Initial Catalog={initialCatalog};Integrated Security=True";

        public static void TestConection()
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = ConnectionString;
                sqlcon.Open();
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    MessageBox.Show($"Coneción a la Base de datos: {initialCatalog}, del servidor: {dataSoure}. Exitosa");
                }
                else
                {
                    MessageBox.Show($"Coneción a la Base de datos: {initialCatalog}, del servidor: {dataSoure}. No se conecto por: {respuesta}");
                }
            }
        }
    }
}