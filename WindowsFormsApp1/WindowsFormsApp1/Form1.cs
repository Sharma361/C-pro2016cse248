using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Student\Desktop\C# pro2016cse248\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");

        public Form1()..





        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand c = con.CreateCommand();
            c.CommandType = CommandType.Text;
            c.CommandText = "Insert into Database1 Value('" + Name.Text + "','" + id.Text + "','" + Sal.Text + "')";
            c.ExecuteNonQuery();
            con.Close();

        }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cmd = "Select * from users";
            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
            DataTable dt = new DataTable();
            dp = Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

        }
    }
}
