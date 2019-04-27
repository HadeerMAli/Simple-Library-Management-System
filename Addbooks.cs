using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS
{
    public partial class Addbooks : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LOT20UJ;Initial Catalog=Library;Integrated Security=True");
        public Addbooks()
        {
            InitializeComponent();
        }
        private void add_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Books values('"+textBox1.Text+"',"+textBox2.Text+",'"+textBox3.Text+"',"+textBox4.Text+","+textBox5.Text+")";
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Data is saved successfully");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }

        
    }
}
