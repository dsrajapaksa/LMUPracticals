using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button1, "Something Somethin !");

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            string textString = linkLabel1.Text;

            string[] keywords = new string[] { "Google", "Microsoft","Video" };
            foreach (string keyword in keywords)
            {
                switch(keyword)
                {
                    case "Google":
                        linkLabel1.Links.Add(textString.IndexOf(keyword), keyword.Length, "www.google.com");
                        break;
                    case "Microsoft":
                        linkLabel1.Links.Add(textString.IndexOf(keyword), keyword.Length, "www.microsoft.com");
                        break;
                    case "Video":
                        linkLabel1.Links.Add(textString.IndexOf(keyword), keyword.Length, @"C:\Users\Dileepa Rajapaksa\Desktop\Connected Mobile Apps with Microsoft Azure.mp4");
                        break;
                    
                    default:
                        break;
                }

            }
            notifyIcon1.BalloonTipTitle ="This is just  notification !";
            notifyIcon1.BalloonTipText = "This is coming from a Form Window !";
            notifyIcon1.ShowBalloonTip(1000);
            notifyIcon1.Visible = true;

         
        }
        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        int i = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            i++;
        }



        int[] arry = { 10, 30, 12,77,90,01,78,23,89,56,34,23,98,98};
        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;

            progressBar1.Value = i * 10;
       
            foreach(int item in arry)
            {

               
                if (item == Convert.ToInt16(textBox1.Text))
                {
                    
                    MessageBox.Show("Item found !");
                    progressBar1.Value = progressBar1.Maximum;
                   // label1.Text = i.ToString();
                    break;
                }
                progressBar1.Value = i * 10;
                Thread.Sleep(2000);
                i++;
            }
         }
    }
}
