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
    public partial class Viewbooks : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LOT20UJ;Initial Catalog=Library;Integrated Security=True");
        public Viewbooks()
        {
            InitializeComponent();
        }

        

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }

        private void Viewbooks_Load(object sender, EventArgs e)
        {
            displaybooks();
        }

       

        

        
        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
              

                con.Open();
                if (comboBox1.Text == "Name")
                {
                    

                    
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-LOT20UJ;Initial Catalog=Library;Integrated Security=True");
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT [ID],[Name],[BookID],[Author],[Price],[Quantity]FROM[dbo].[Books] where Name like'" + textBox5.Text + "%'", con);
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                }
                else if (comboBox1.Text == "Author")
                {
                    
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-LOT20UJ;Initial Catalog=Library;Integrated Security=True");
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT [ID],[Name],[BookID],[Author],[Price],[Quantity]FROM[dbo].[Books]where Author like'" + textBox5.Text + "%'", con);
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;



                }
                con.Close();


              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int i;
            i = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            



            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select  *from Books where ID =" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["Name"].ToString();
                    textBox2.Text = dr["BookID"].ToString();
                    textBox3.Text = dr["Author"].ToString();
                    textBox4.Text = dr["Price"].ToString();
                    textBox6.Text = dr["Quantity"].ToString();

                }
               

                con.Close();



              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        public void displaybooks()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select  *from Books";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Books set Name='" + textBox1.Text + "',BookID=" + textBox2.Text + ",Author='" + textBox3.Text + "',Price=" + textBox4.Text + ",Quantity=" + textBox6.Text + "where ID=" + i + "";
                cmd.ExecuteNonQuery();
                con.Close();
                displaybooks();
                MessageBox.Show("Record updated successfully");
                panel1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM [dbo].[Books]WHERE Name='"+textBox1.Text+"' ";
                cmd.ExecuteNonQuery();
                con.Close();
                displaybooks();
                MessageBox.Show("data deleted successfully");
                panel1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }

    }



