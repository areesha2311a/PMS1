using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Microsoft.Data.SqlClient;

namespace PMS1
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection vonn = new SqlConnection(" Data Source = DESKTOP-MG6E82N\\SQLEXPRESS;   Initial Catalog = PMS ; Integrated  Secureity = True;");
        private void btninsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customers (customer_name, email, phone, address, city) VALUES (@N ,@E @P ,@C)", vonn);
            cmd.Parameters.AddWithValue("@N" ,textBox1.Text);
            cmd.Parameters.AddWithValue("@E", textBox2.Text);

            cmd.Parameters.AddWithValue("@P", textBox3.Text);

            cmd.Parameters.AddWithValue("@C", textBox4.Text);
        }
    }
}
