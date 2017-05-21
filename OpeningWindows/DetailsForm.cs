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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {

         

        }
        public DetailsForm(string name, string userName, string dateOfBirth,string role )
        {
            InitializeComponent();

            label1.Text = name;
            label2.Text = userName;
            label3.Text = dateOfBirth;
            label4.Text = role;

            toolTip1.SetToolTip(button1, "This is just a button!");
            toolTip1.AutoPopDelay = 0;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;


        }
        public DetailsForm(Person person)
        {
            InitializeComponent();

            label1.Text = person.name;
            label2.Text = person.userName;
            label3.Text = Convert.ToString(person.dateofBirth);
            label4.Text = person.role;

            webBrowser1.Url = new Uri(@"http://www.google.com");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //webBrowser1.Url = new Uri(@"http://www.google.com");
            //webBrowser1.Show();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.button1, "My button1");
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
