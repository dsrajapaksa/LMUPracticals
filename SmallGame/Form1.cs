using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateLocation();

        }

        int initialX = 0;
        int InitialY = 0;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            initialX++;
            UpdateLocation();
        }

        public void UpdateLocation()
        {
            label1.Location = new Point(initialX, InitialY);
        }
    }
}
