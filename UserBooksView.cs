using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class UserBooksView : Form
    {
        public UserBooksView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string b = "oop";
            string id = "12345";

            if (textBox1.Text == b)
            {
                name.Text = "oop";
                Author.Text = "mohamed";
                bookID.Text = "12345";
            }
            else if (textBox1.Text == id)
            {
                name.Text = "oop";
                Author.Text = "mohamed";
                bookID.Text = "12345";
            }
            else
            {
                MessageBox.Show("this book dosn't exist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string u = "Hadeer";

            if (username.Text == u)
            {
                MessageBox.Show("Are you sure you want to rent this book", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            else
            {
                MessageBox.Show("Please enter correct UserName", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}

  