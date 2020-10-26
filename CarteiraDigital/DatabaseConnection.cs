using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTable = System.Data.DataTable;

namespace SQLDatabase
{

    public class connectionString
    {
        public static SqlConnection sqlConn = new SqlConnection("server=" + Environment.MachineName + @"\SQLEXPRESS; Database=carteiraDigital;Integrated Security=SSPI;");
    }

    public class DatabaseConnect
    {
        //static readonly string  connectionString = "server=" + Environment.MachineName + @"\SQLEXPRESS; Database=carteiraDigital;Integrated Security=SSPI;";

        //SqlConnection sqlConnection = ;

        
        public static void OpenSqlConnection()
        {
            //string connectionString = "server=" + Environment.MachineName + @"\SQLEXPRESS; Database=carteiraDigital;Integrated Security=SSPI;";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //SqlConnection sqlConn = sqlConnection;

            
            connectionString.sqlConn.Open();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM TipoDocumento ", sqlConn);
            //SqlDataReader dr = cmd.ExecuteReader();

            
        }

        public static void CloseSqlConnection()
        {
            connectionString.sqlConn.Close();
        }

    }

    public class DatabaseRead
    {

        public static DataSet teste()
        {
            var dt = new DataSet();

            DatabaseConnect.OpenSqlConnection();

            //SqlDataReader dr;

            //SqlCommand cmd = new SqlCommand("SELECT * FROM TipoDocumento ", connectionString.sqlConn);

            var dataAdapter = new SqlDataAdapter("SELECT * FROM TipoDocumento ", connectionString.sqlConn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            //dr = cmd.ExecuteReader();
            
            dataAdapter.Fill(dt);

            DatabaseConnect.CloseSqlConnection();

            return dt;


        }
        
    }
}
