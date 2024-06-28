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
    public partial class Add_Employee_Form : Form
    {

        private SqlConnection con = new SqlConnection(@"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Add_Employee_Form()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM dbo.Store",con);
            SqlDataReader red = cmd.ExecuteReader();
            while(red.Read())
            {
                comboBox_Role.Items.Add(red[0].ToString());
            }
            con.Close();
            cmd.Dispose();
            red.Dispose();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT RoleName FROM dbo.Role", con);
            SqlDataReader red2 = cmd.ExecuteReader();
            while (red2.Read())
            {
                comboBox_Role.Items.Add(red2[0].ToString());
            }
            con.Close();
            cmd2.Dispose();
            red2.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_Name.TextLength>0 && textBox_Email.TextLength>0 && comboBox_Role.SelectedIndex.ToString()!="")
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DECLARE @roleId nvarchar(20)\r\nDECLARE @storeId nvarchar(20)\r\n\r\nSELECT @roleId = RoleID FROM dbo.Role WHERE RoleName = @roleName\r\nSELECT @storeId = StoreID FROM dbo.Store WHERE Name = @storeName\r\n\r\nINSERT INTO dbo.Employee (Name, Email, RoleId, StoreId) VALUES(@name, @email, @roleId, @storeId)", con);
                cmd.Parameters.AddWithValue("@name", textBox_Name.Text.ToString());
                cmd.Parameters.AddWithValue("@email", textBox_Email.Text);
                cmd.Parameters.AddWithValue("@roleName", comboBox_Role.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@storeName", comboBox_Store.SelectedItem.ToString());
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Employee registered successfully!");
                    comboBox_Role.ResetText();
                    textBox_Name.Text = "";
                    textBox_Email.Text = "";
                }
                else
                    MessageBox.Show("Employee was not registered.");
                con.Close();
            }
            catch (System.NullReferenceException)
            {
                con.Close();
                MessageBox.Show("Make sure all fields are correclty filled!");
            }
            else
                MessageBox.Show("Make sure all fields are correclty filled!");
        }
    }
}
