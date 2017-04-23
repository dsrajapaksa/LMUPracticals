using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGuiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMe_Button_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hello, " + nameTextBox.Text;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            valueTextBox.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dateTimePicker1.Value.Year;
            label2.Text = age.ToString();
        }
    }
}
