using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = textBox1.Text;
            String Password = textBox2.Text;
            if (Username == "admin" && Password == "123")
            {
                this.Hide();
                MessageBox.Show("Login");
                Form2 fm2 = new Form2();
                fm2.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exist?", "Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else 
            {
            this.Hide();
            Form1 fm1=new Form1();
                fm1.Show();

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
                        if (e.KeyCode == Keys.Enter)
            {
                        textBox2.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        }
    }

