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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

       
       

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbooks a = new Addbooks();
            a.Show();
            this.Hide();
        }

        private void viewBooksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Viewbooks v = new Viewbooks();
            v.Show();
            this.Hide();
        }

        private void addUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rentBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBooksView ub = new UserBooksView();
            ub.Show();
        }
    }
}
