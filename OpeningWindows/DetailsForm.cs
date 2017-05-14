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
            InitializeComponent();
        }
        public DetailsForm(string name, string userName, string dateOfBirth,string role )
        {
            InitializeComponent();

            label1.Text = name;
            label2.Text = userName;
            label3.Text = dateOfBirth;
            label4.Text = role;

        }
        public DetailsForm(Person person)
        {
            InitializeComponent();

            label1.Text = person.name;
            label2.Text = person.userName;
            label3.Text = Convert.ToString(person.dateofBirth);
            label4.Text = person.role;

        }


    }
}
