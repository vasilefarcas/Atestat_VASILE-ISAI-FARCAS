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
    public partial class Modify_Delete_Shop_Form : Form
    {
        private SqlConnection con = new SqlConnection(@"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Modify_Delete_Shop_Form()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM dbo.Store", con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                comboBox_EmployeeSelect.Items.Add(red[0].ToString());
            }
            cmd.Dispose();
            red.Dispose();
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT RoleName FROM dbo.Role", con);
            SqlDataReader red2 = cmd2.ExecuteReader();
            while (red2.Read())
            {
                comboBox_EmployeeSelect.Items.Add(red2[0].ToString());
            }
            cmd2.Dispose();
            red2.Dispose();
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Name FROM dbo.Employee", con);
            SqlDataReader red3 = cmd3.ExecuteReader();
            while (red3.Read())
            {
                comboBox_EmployeeSelect.Items.Add(red3[0].ToString());
            }
            cmd3.Dispose();
            red3.Dispose();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Modify button
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Name.TextLength > 0 && textBox_Email.TextLength > 0 && comboBox_EmployeeSelect.SelectedIndex.ToString() != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("\r\nDECLARE @roleId nvarchar(20)\r\nDECLARE @storeId nvarchar(20)\r\n\r\nSELECT @roleId = RoleID FROM dbo.Role WHERE RoleName = @roleName\r\nSELECT @storeId = StoreID FROM dbo.Store WHERE Name = @storeName\r\n\r\nUPDATE dbo.Employee \r\n\tSET \r\n\t\tName = @name,\r\n\t\tEmail = @email,\r\n\t\tRoleId = @roleId,\r\n\t\tStoreId = @storeId\r\n\tWHERE userId = @employeeId", con);
                    cmd.Parameters.AddWithValue("@roleName", comboBox_Role.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@storeName", comboBox_Store.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@name", textBox_Name.Text.ToString());
                    cmd.Parameters.AddWithValue("@employeeId", label_Id_Value.Text.ToString());
                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee details updated successfully!");
                    label5.Text = "";
                    textBox_Name.Text = "";
                    textBox_Email.Text = "";
                    comboBox_EmployeeSelect.ResetText();
                    comboBox_EmployeeSelect.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("SELECT Name FROM dbo.Employee", con);
                    SqlDataReader red1 = cmd1.ExecuteReader();
                    while (red1.Read())
                    {
                        comboBox_EmployeeSelect.Items.Add(red1[0].ToString());
                    }
                    cmd1.Dispose();
                    red1.Dispose();
                    cmd.Dispose();
                    con.Close();
                }
                catch (System.InvalidOperationException)
                {
                    con.Close();
                    MessageBox.Show("Select an employee first and fill correctly all fields.");
                }
            }
            else
                MessageBox.Show("Select an employee first and fill correctly all fields.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StoreID, Name, Address  FROM dbo.Store WHERE Nume=@name", con);
                cmd.Parameters.AddWithValue("name", comboBox_EmployeeSelect.SelectedItem.ToString());
                SqlDataReader red = cmd.ExecuteReader();
                if (red.Read())
                {
                    label5.Text = red[0].ToString();
                    textBox_Name.Text = red[1].ToString();
                    textBox_Email.Text = red[2].ToString();
                }
                con.Close();
                cmd.Dispose();
            }
            catch (System.InvalidOperationException)
            {
                con.Close();
            }
        }
        // Delete button
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_EmployeeSelect.SelectedIndex.ToString() != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Id=@id", con);
                    cmd.Parameters.AddWithValue("id", label5.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Employee data deleted successfully.");

                        label5.Text = "";
                        textBox_Name.Text = "";
                        textBox_Email.Text = "";
                        comboBox_EmployeeSelect.ResetText();
                        comboBox_EmployeeSelect.Items.Clear();
                        SqlCommand cmd1 = new SqlCommand("SELECT Name FROM dbo.Employee", con);
                        SqlDataReader red1 = cmd1.ExecuteReader();
                        while (red1.Read())
                        {
                            comboBox_EmployeeSelect.Items.Add(red1[0].ToString());
                        }
                        cmd1.Dispose();
                        red1.Dispose();

                    }
                    else
                        MessageBox.Show("Employee not deleted.");
                }
                catch (System.InvalidOperationException)
                {
                    label5.Text = "";
                    textBox_Name.Text = "";
                    textBox_Email.Text = "";
                    comboBox_EmployeeSelect.ResetText();
                    comboBox_EmployeeSelect.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM dbo.Employee", con);
                    SqlDataReader red1 = cmd1.ExecuteReader();
                    while (red1.Read())
                    {
                        comboBox_EmployeeSelect.Items.Add(red1[1].ToString());
                    }
                    cmd1.Dispose();
                    red1.Dispose();
                }
            }
            else
                MessageBox.Show("Select the employee you desire to delete.");
        }
    }
}
