using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpeningWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "Amal", password = "12345";

            if(userNameTxt.Text == user && passwordTxt.Text == password)
            {
                HomePage hp = new HomePage(userNameTxt.Text);

                //this.Hide();
                //hp.ShowDialog();
                //this.Dispose();

                //this.Close() ;
                //hp.Show();

       
                this.Hide();
                hp.ShowDialog();
                this.Close();



            }
            else
            {
                MessageBox.Show("User name or Password Incorrect !");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm regf = new RegisterForm();
            this.Hide();
            regf.ShowDialog();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
