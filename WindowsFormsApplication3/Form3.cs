using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
            {
                string MyConnection2 = "server=localhost;user id=root;password=;database=lms";
                string Query = "insert into registration(reg_no,registration_date,full_name,nic_no,date_of_birth,gender,address,mobile,home,email) values('" + this.textBox1.Text + "','" + this.dateTimePicker1.Text + "','" + this.textBox2.Text + "','"+ this.textBox3.Text+"','" + this.dateTimePicker2.Text+"','"+this.comboBox1.Text+"','"+this.richTextBox1.Text+"','"+this.textBox5.Text+"','"+this.textBox6.Text+"','"+this.textBox8.Text+"');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     
                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {

                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    string MyConnection2 = "server=localhost;user id=root;password=;database=lms";
                    string Query = "SELECT * FROM registration WHERE Reg_No='" + textBox1.Text + "'";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    while (MyReader2.Read())
                    {

                    }

                    MyConn2.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(MyCommand2);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                   // textBox1.Text = dt.Rows[0][1].ToString();
                    dateTimePicker1.Text = dt.Rows[0][1].ToString();
                    textBox2.Text = dt.Rows[0][2].ToString();
                    textBox3.Text = dt.Rows[0][3].ToString();
                    dateTimePicker2.Text = dt.Rows[0][4].ToString();
                    comboBox1.Text = dt.Rows[0][5].ToString();
                    richTextBox1.Text = dt.Rows[0][6].ToString();
                    textBox5.Text = dt.Rows[0][7].ToString();
                    textBox6.Text = dt.Rows[0][8].ToString();
                    textBox8.Text = dt.Rows[0][9].ToString();
                   
                }
                else
                {
                    MessageBox.Show("Enter Registration Card Number to search");
                }
           }
            catch (Exception)
            {
              MessageBox.Show("Error");

            }

   

      
        }
    }
}
