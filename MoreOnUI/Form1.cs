using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreOnUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
               }

        private void fromComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath="";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                string content = File.ReadAllText(filePath);
                

                richTextBox1.Text = content;

            }

         
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            printPreviewDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var filePath = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;

                File.WriteAllText(filePath, richTextBox1.Text);

            }
            
        }

        private void changeFontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}
