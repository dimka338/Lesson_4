using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte Side1;
            int p, s;
            Side1 = byte.Parse(textBox1.Text);
            byte Side2;
            Side2 = byte.Parse(textBox2.Text);
            p = 2 * (Side1 + Side2);
            s = Side1 * Side2;
            label3.Text = "Периметр = " + p.ToString();
            label4.Text = "Площа = " + s.ToString();
            label3.Visible = true;
            label4.Visible = true;
        }
    }
}
