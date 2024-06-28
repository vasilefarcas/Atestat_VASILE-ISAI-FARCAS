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
using System.Configuration;

namespace LICENTA_VASILE_ISAI_FARCAS
{
    public partial class Add_Item_Form : Form
    {
        private SqlConnection con = new SqlConnection(@"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Add_Item_Form()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ProductCategory",con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
                comboBox_Product_Category.Items.Add(red[4].ToString());
            con.Close();
            red.Dispose();
            cmd.Dispose();
        }

        private void button_Form_Dispose_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Close();
        }

        private void button_Add_Item_Click(object sender, EventArgs e)
        {
            if (textBox_Product_Name.Text.Length > 0 && textBox_Product_Name.Text.Length > 0 && textBox_Product_Name.Text.Length > 0 && textBox_Product_Name.Text.Length > 0 && comboBox_Product_Category.SelectedIndex.ToString().Length > 0)
            {
                try
                {
                    con.Open();
                    // SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Product(ProductName, CategoryId, Price, Description) VALUES(@productName, @productCategory, @productPrice, @productDescription)", con);
                    SqlCommand cmd = new SqlCommand("DECLARE @categoryID int;\r\n\r\nSELECT @categoryID =CategoryID\r\nFROM dbo.ProductCategory\r\nWHERE Name = @productCategory\r\n\r\nINSERT INTO dbo.Product(ProductName, CategoryId, Price, Description) VALUES(@productName, @categoryId, @productPrice, @productDescription)", con);

                    cmd.Parameters.AddWithValue("@productName", textBox_Product_Name.Text);
                    cmd.Parameters.AddWithValue("@productCategory", comboBox_Product_Category.SelectedItem);
                    cmd.Parameters.AddWithValue("@productPrice", Convert.ToInt32(textBox_Product_Price.Text));
                    cmd.Parameters.AddWithValue("@productDescription", textBox_Product_Description.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Item registered successfully!");
                        textBox_Product_Name.Text = "";
                        textBox_Product_Price.Text = "";
                        textBox_Product_Description.Text = "";
                        comboBox_Product_Category.ResetText();
                    }
                    else
                        MessageBox.Show("Item not registered.");
                    cmd.Dispose();
                    con.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    con.Close();
                    MessageBox.Show("Check the data.");
                }
            }
            else
                MessageBox.Show("Check the data.");
        }
    }
}
