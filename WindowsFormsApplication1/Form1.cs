using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        String todoInput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            todoInput = newTodo.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!todoInput.Equals(""))
            {
                todoListing.Items.Add(todoInput);
                newTodo.Text = "";
                todoInput = "";
            }
        }

        private void toDelete_Click(object sender, EventArgs e)
        {
            foreach (String item in todoListing.CheckedItems)
            {
                todoListing.Items.Remove(item);
            }
        }
    }
}
