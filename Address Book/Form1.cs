using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hii I am " + textBox1.Text + " " + textBox2.Text);
            MessageBox.Show("My Address is  " + textBox3.Text+" "+textBox4.Text+" "+textBox5.Text);
            MessageBox.Show("And Pincode is " + textBox6.Text);
            MessageBox.Show("My Phone Number is " + textBox7.Text);
            MessageBox.Show("Gmail ID is " + textBox8.Text);
        }
    }
}
