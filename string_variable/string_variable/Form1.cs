using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname, gender, job;
            
            name = textBox1.Text;
            surname = textBox2.Text;
            gender = textBox3.Text;
            job = textBox4.Text;
            label6.Text = name;
            label7.Text = surname;
            label8.Text = gender ;
            label9.Text = job ;
            listBox1.Items.Add(label6.Text + " " + label7.Text + " " + label8.Text + " " + label9.Text);
            

        }
    }
}
