using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDato
{
    class Connection
    {
        private static readonly string dataSoure = "DESKTOP-07RQMUT";
        private static readonly string initialCatalog = "dbventas";

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
                    respuesta = $"Coneción a la Base de datos: {initialCatalog}, del servidor: {dataSoure}. Exitosa.";
                    sqlcon.Close();
                }
                else
                {
                    respuesta = $"Coneción a la Base de datos: {initialCatalog}, del servidor: {dataSoure}. No se conecto por: {respuesta}.";
                }

                MessageBox.Show(respuesta);
            }
        }
    }
}