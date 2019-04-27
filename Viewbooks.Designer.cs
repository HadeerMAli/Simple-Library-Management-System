namespace LMS
{
    partial class Viewbooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.enterdata = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.bookquantity = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.bookauthor = new System.Windows.Forms.Label();
            this.bookprice = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name ",
            "Author"});
            this.comboBox1.Location = new System.Drawing.Point(13, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Name ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // enterdata
            // 
            this.enterdata.AutoSize = true;
            this.enterdata.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterdata.Location = new System.Drawing.Point(35, 105);
            this.enterdata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterdata.Name = "enterdata";
            this.enterdata.Size = new System.Drawing.Size(106, 24);
            this.enterdata.TabIndex = 21;
            this.enterdata.Text = "Enter Data";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(25, 156);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 20;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(663, 85);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 35;
            // 
            // bookquantity
            // 
            this.bookquantity.AutoSize = true;
            this.bookquantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookquantity.Location = new System.Drawing.Point(450, 81);
            this.bookquantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookquantity.Name = "bookquantity";
            this.bookquantity.Size = new System.Drawing.Size(136, 24);
            this.bookquantity.TabIndex = 34;
            this.bookquantity.Text = "Book Quantity";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(568, 181);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(105, 44);
            this.delete.TabIndex = 33;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(717, 181);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(103, 44);
            this.cancel.TabIndex = 32;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // bookauthor
            // 
            this.bookauthor.AutoSize = true;
            this.bookauthor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookauthor.Location = new System.Drawing.Point(450, 9);
            this.bookauthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookauthor.Name = "bookauthor";
            this.bookauthor.Size = new System.Drawing.Size(119, 24);
            this.bookauthor.TabIndex = 31;
            this.bookauthor.Text = "Book Author";
            // 
            // bookprice
            // 
            this.bookprice.AutoSize = true;
            this.bookprice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookprice.Location = new System.Drawing.Point(21, 134);
            this.bookprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookprice.Name = "bookprice";
            this.bookprice.Size = new System.Drawing.Size(103, 24);
            this.bookprice.TabIndex = 30;
            this.bookprice.Text = "Book Price";
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid.Location = new System.Drawing.Point(21, 77);
            this.bookid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(81, 24);
            this.bookid.TabIndex = 29;
            this.bookid.Text = "Book ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 134);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(663, 9);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 77);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 26;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(411, 181);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(103, 44);
            this.update.TabIndex = 25;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 24;
            // 
            // bookname
            // 
            this.bookname.AutoSize = true;
            this.bookname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookname.Location = new System.Drawing.Point(21, 26);
            this.bookname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(112, 24);
            this.bookname.TabIndex = 23;
            this.bookname.Text = "Book Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 297);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookprice);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.bookquantity);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.bookauthor);
            this.panel1.Controls.Add(this.bookname);
            this.panel1.Controls.Add(this.bookid);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(150, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 240);
            this.panel1.TabIndex = 37;
            this.panel1.Visible = false;
            // 
            // Viewbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources._48362173_506100653210794_6967280893710827520_n;
            this.ClientSize = new System.Drawing.Size(987, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.enterdata);
            this.Controls.Add(this.textBox5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Viewbooks";
            this.Text = "Viewbooks";
            this.Load += new System.EventHandler(this.Viewbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label enterdata;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label bookquantity;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label bookauthor;
        private System.Windows.Forms.Label bookprice;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label bookname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}