using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{
    public partial class Form3 : Form
    {
        double f, s, r;string op;
        public Form3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            f = Convert.ToDouble(textBox1.Text);
            s = Convert.ToDouble(textBox1.Text);
            
            r = f + s; r = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "" + r;
            textBox1.Clear();
           
          
           // textBox1.Text = ""+r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             textBox1.Text = "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";
         
           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "*";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }
    }
}
