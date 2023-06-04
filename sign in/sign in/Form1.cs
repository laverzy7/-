using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Text == "admin" && pass.Text == "admin")
            {
                MessageBox.Show("Вы успешно вошли!");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Пароль и логин - admin");
                pass.Clear();
                login.Clear();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pass.Clear();
            login.Clear();
        }
    }
 }




