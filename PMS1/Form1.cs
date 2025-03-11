using System.DirectoryServices.ActiveDirectory;

namespace PMS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Customers form = new Customers();
            form.TopLevel = false;
            mainpanel.Controls.Add(form);
            form.Show();
        }

        private void btncategories_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            categories form = new categories();
            form.TopLevel = false;
            mainpanel.Controls.Add(form);
            form.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Products form = new Products();
            form.TopLevel = false;
            mainpanel.Controls.Add(form);
            form.Show();
        }
    }
}
