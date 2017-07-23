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


        public static bool putDataToTable(Student stundetObject)
        {
            try
            {
                cmd = new SqlCommand
                       ("INSERT INTO Student(id,fname,lname,address,gender,city,datejoined,age,tel)"+ 
                       "values(@Id,@Fname,@Lname,@Address,@Gender,@City,@DateJoined,@Age,@Tel )", sqlCon);
                sqlCon.Open();
                cmd.Parameters.AddWithValue("@Id", stundetObject.id);
                cmd.Parameters.AddWithValue("@Fname", stundetObject.fname);
                cmd.Parameters.AddWithValue("@Lname", stundetObject.lname);
                cmd.Parameters.AddWithValue("@Address", stundetObject.address);
                cmd.Parameters.AddWithValue("@Gender", stundetObject.gender);
                cmd.Parameters.AddWithValue("@City", stundetObject.city);
                cmd.Parameters.AddWithValue("@DateJoined", stundetObject.datejoined);
                cmd.Parameters.AddWithValue("@Age", stundetObject.age);
                cmd.Parameters.AddWithValue("@Tel", stundetObject.phone);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
