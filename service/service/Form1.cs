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

        private void button1_Click(object sender, EventArgs e)
        {



            con.Open();
            SqlDataAdapter("Select * from storeimage where id ='")
        }

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            //FileStream fs1 = new FileStream(img.Text);
            Byte[] mypic = File.ReadAllBytes(openFileDialog1.FileName);

            cmd1.CommandText = "Insert into imagestore values('" + ID.Text + "','" + pictureBox1.Image + "')";
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("saved");

        }

        private void store_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                img.Text = openFileDialog1.FileName;

            pictureBox1.ImageLocation = img.Text;
            //pictureBox1.Image = Convert.ToSByte(openFileDialog1.FileName);
        }
    }
}
