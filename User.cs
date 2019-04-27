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
using System.IO;

namespace LMS
{
    public partial class User : Form
    {
       
        public User()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LOT20UJ;Initial Catalog=imagetest;Integrated Security=True");
        string imagelocation = "";
        SqlCommand cmd;


        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imagelocation;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            byte[] images = null;
            FileStream stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);
            try
            {
               

                con.Open();
                string sqlquery = "Insert into Users(Name,Email,Password,ContactNumber,Image)Values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',@images  )";
                cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The Data is saved successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }
    }
}
