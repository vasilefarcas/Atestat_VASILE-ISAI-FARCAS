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

namespace LICENTA_VASILE_ISAI_FARCAS
{
    public partial class Store_Add_Form : Form
    {
        private SqlConnection con = new SqlConnection(@"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public Store_Add_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_Name.TextLength > 0 && textBox_Address.TextLength > 0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Store(Name, Address) VALUES(@name, @address)", con);
                    cmd.Parameters.AddWithValue("@name", textBox_Name.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_Address.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Shop details loaded successfully!");
                        textBox_Name.Text = "";
                        textBox_Address.Text = "";
                    }
                    else
                        MessageBox.Show("Verify the data inside the fields.");
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verify the data inside the fields. Make sure the fields are filled.");
            }
        }
    }
}
