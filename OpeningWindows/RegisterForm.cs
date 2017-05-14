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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
         
            //Adding users to Combo Box
            roleComboBox.Items.Add("Admin");
            roleComboBox.Items.Add("Super User");
            roleComboBox.Items.Add("Guest");
            roleComboBox.SelectedIndex = 1;
        }

        Person p1;
        private void button1_Click(object sender, EventArgs e)
        {
   
            //DetailsForm df = new DetailsForm(nameText.Text, userNameText.Text, dateOfBirth.Text, roleComboBox.Text);
            //df.Show();

            p1 = new Person();//Create the object 

            p1.name = nameText.Text;
            p1.userName = userNameText.Text;
            p1.dateofBirth = Convert.ToDateTime(dateOfBirth.Text);
        //  p1.gender = Convert.ToString(genderGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked));
            p1.role = roleComboBox.Text;

            DetailsForm df = new DetailsForm(p1);
            df.Show();


        }
    }
}
