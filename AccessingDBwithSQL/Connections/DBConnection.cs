using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccessingDBwithSQL.Connections
{
    public static class DBConnection
    {
        private static string connectionString =@"Data Source=DESKTOP-TG2D98G\SQLEXPRESS;Initial Catalog=CompanyDB;Integrated Security=True";

        static SqlConnection con;
        
        //To get the connection to the DB 
        public static SqlConnection getConnection()
        {
            try
            {
                con = new SqlConnection(connectionString);

                return con;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

                return null;
            }
        }


    }
}
