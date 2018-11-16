using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Getweather_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client o = new ServiceReference1.Service1Client();
            int res = o.Getweather(city.Text);
            label2.Text = "The Weather is : "+res.ToString();
        }
    }
}
