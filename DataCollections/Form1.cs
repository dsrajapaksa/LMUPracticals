using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            getData();
            dataGridView1.DataSource = personsList;

            PopulateData();
        }

        public void PopulateData()
        {
            //string[] cities = { "Colombo", "Gampaha", "Panadura", "Kalaniya" };
            //foreach(string city in cities)
            //{
            //  listBox1.Items.Add(city);
            //}
            //listBox1.SelectedIndex = 3;

            //--1st Method to populate Objects to combo Box
            foreach (Person p in personsList)
            {
                cityCombo.Items.Add(p.City);
            }
            //--2nd Method to populate Objects to combo Box
          //  cityCombo.DataSource = personsList;
           // cityCombo.DisplayMember = "City";
        }

        List<Person> personsList;
        public void getData()
        {
            personsList = new List<Person>()
            {
                new Person {id=10,Name="Saman",age=12,City="Colombo" },
                new Person {id=12,Name="Kamal",age=18,City="Gampaha" },
                new Person{id=13,Name="Amal",age=20,City="Kaluthara" }
            };
        }

    }
}
