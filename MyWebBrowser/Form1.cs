using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Url = new Uri("http://google.com");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://" + textBox1.Text);
            toolStripStatusLabel1.Text = webBrowser1.Url.ToString();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripStatusLabel1.Text = webBrowser1.Url.ToString();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if(!webBrowser1.CanGoBack)
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }

            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            if (e.CurrentProgress > 0)
                toolStripProgressBar1.Value = (int)e.CurrentProgress;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
