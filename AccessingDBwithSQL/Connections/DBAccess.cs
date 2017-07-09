using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccessingDBwithSQL.Connections
{
    public static class DBAccess

    {
        /// <summary>
        /// 
        /// </summary>
        static SqlCommand cmd;
        static SqlDataAdapter adapt;
        static SqlConnection sqlCon;

        public static DataTable getDataTable(string sqlQurey)
        {
            try
            {
                sqlCon = DBConnection.getConnection();
                sqlCon.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand(sqlQurey, sqlCon);
                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);
                sqlCon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
