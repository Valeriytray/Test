using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDD
{
    public partial class Form1 : Form
    {
        //Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ну вспоминай! Там не сложно");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите все даннные!");
                return;
            }
            else if(textBox1.Text == "inspector" & textBox2.Text == "inspector")
            {
                Form4 F4 = new Form4();
                F4.Show();
                this.Hide();
            }
            else if(textBox1.Text != "" || textBox2.Text != "")
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

    }
}
