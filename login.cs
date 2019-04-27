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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LOT20UJ;Initial Catalog=Library;Integrated Security=True");
        int count;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        
            

       
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Admin where Name='" + textBoxname.Text + "'and Admin_ID='" + textBoxpassword.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = int.Parse(dt.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("Please enter the correct username & ID");
            }
            else
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        
    }
    }
    

