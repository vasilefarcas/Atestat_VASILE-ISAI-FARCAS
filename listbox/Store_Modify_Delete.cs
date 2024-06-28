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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LICENTA_VASILE_ISAI_FARCAS
{
    public partial class Store_Modify_Delete_Form : Form
    {
        private SqlConnection con = new SqlConnection(@"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public Store_Modify_Delete_Form()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM dbo.Store", con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
                comboBox_Shop.Items.Add(red[0].ToString());
            con.Close();
            label_StoreId_Value.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT StoreID, Name, Address FROM Clase WHERE Name =@name", con);
            cmd.Parameters.AddWithValue("name", comboBox_Shop.SelectedItem.ToString());
            SqlDataReader red = cmd.ExecuteReader();
            if (red.Read())
            {
                label_StoreId_Value.Text = red[0].ToString();
                textBox_Name.Text = red[1].ToString();
                textBox_Address.Text = red[2].ToString();
            }
            con.Close();
        }

        private void Modify_Delete_Employee_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (comboBox_Shop.SelectedIndex.ToString().Length > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Store WHERE Name = @name", con);
                    cmd.Parameters.AddWithValue("@name", comboBox_Shop.SelectedItem.ToString());
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        comboBox_Shop.Items.Clear();
                        comboBox_Shop.ResetText();
                        SqlCommand cmd1 = new SqlCommand("SELECT Name FROM dbo.Store", con);
                        SqlDataReader red1 = cmd1.ExecuteReader();
                        while (red1.Read())
                            comboBox_Shop.Items.Add(red1[0].ToString());
                        textBox_Name.Text = "";
                        textBox_Address.Text = "";
                        comboBox_Shop.ResetText();
                        MessageBox.Show("Shop deleted successfully!");
                    }
                    else
                        MessageBox.Show("Shop was not deleted.");
                    con.Close();
                    cmd.Dispose();
                }
                catch (System.NullReferenceException)
                {
                    con.Close();
                }
            }
            else
                MessageBox.Show("Choose a shop from the dropdown and make sure all fields are corectly filled.");
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Name.Text.Length > 0 && textBox_Address.Text.Length > 0 && comboBox_Shop.SelectedIndex.ToString().Length > 0)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Store SET Name = @name, Address = @address WHERE StoreId=@id", con);
                    cmd.Parameters.AddWithValue("@id", label_StoreId_Value.Text.ToString());
                    cmd.Parameters.AddWithValue("@name", textBox_Name.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_Address.Text);
                    var i = cmd.ExecuteNonQuery();
                    MessageBox.Show("Shop details updated successfully!");
                    textBox_Name.ResetText();
                    textBox_Address.ResetText();
                    comboBox_Shop.ResetText();
                    comboBox_Shop.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("SELECT Name FROM dbo.Store", con);
                    SqlDataReader red1 = cmd1.ExecuteReader();
                    while (red1.Read())
                        comboBox_Shop.Items.Add(red1[0].ToString());
                    comboBox_Shop.ResetText();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Shop details not updated. Check all fields.");
                    con.Close();
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Shop details not updated. Check all fields.");
                con.Close();
            }
        }
    }
}
