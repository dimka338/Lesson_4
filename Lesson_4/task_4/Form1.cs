using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cord1 = float.Parse(textBox1.Text);
            float cord2 = float.Parse(textBox2.Text);
            float cord3 = float.Parse(textBox3.Text);
            float cord4 = float.Parse(textBox4.Text);
            double dif1 = (cord1 + cord2) / 2;
            double dif2 = (cord3 + cord4) / 2;
            //label3.Text = "Координати середини відрізка: " + "(" + dif1.ToString( ) + ";" + dif2.ToString ( ) + ")";
            label3.Text = "Координати середини відрізка: " + " " + dif1.ToString() + "      " + dif2.ToString();
        }
    }
}
