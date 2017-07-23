using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessingDBwithSQL.Connections;

namespace AccessingDBwithSQL
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            refreshandGetData();
        }
            

        public void refreshandGetData()
        {
            string sqlQuery = "SELECT * FROM Student";
            employeeDataGridView.DataSource = DBAccess.getDataTable(sqlQuery);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student std = new Student();

            std.id =Convert.ToInt16( iDTextBox.Text);
            std.fname = fNAMETextBox.Text;
            std.lname = lNAMETextBox.Text;
            std.address = aDDRESSTextBox.Text;
            std.city = cITYTextBox.Text;
            std.phone = Convert.ToInt16(tELTextBox.Text);
            std.gender = gENDERTextBox.Text;
            std.datejoined = "" ;
            std.age = Convert.ToInt16(aGETextBox.Text);


            DBAccess.putDataToTable(std);
            refreshandGetData();
        }



    }
}
