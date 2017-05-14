using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_item_button_Click(object sender, EventArgs e)
        {
            todoList.Items.Add(itemName.Text);
        }

        private void todoList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //  todoList.Items.Remove(todoList.SelectedItem);
            todoList.Items.Remove(e.Index);

        }

        private void todoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            todoList.Items.Remove(todoList.SelectedItem);
        }
    }
}
