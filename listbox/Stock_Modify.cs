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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace LICENTA_VASILE_ISAI_FARCAS
{
    public partial class Check_Stock_Form : Form
    {
        private SqlConnection con = new SqlConnection(@"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Check_Stock_Form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Quantity.Text.Length > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DECLARE @categoryId int\r\nDECLARE @storeId int\r\n\r\nSELECT @categoryId = CategoryID FROM dbo.ProductCategory WHERE Name = @categoryName\r\nSELECT @storeId = StoreId FROM dbo.Store WHERE Name = @storeName\r\n\r\nUPDATE dbo.Product SET ProductName = @productName, CategoryId = @categoryId, Price = @price, [Description] = @description WHERE ProductID = @productId\r\nUPDATE dbo.Stock SET Quantity = @quantity WHERE ProductId = @productId AND StoreId = @storeId\r\n", con);
                    cmd.Parameters.AddWithValue("@productId", label_ItemId_Value.Text.ToString());
                    cmd.Parameters.AddWithValue("@categoryName", label_Category_Value.Text.ToString());
                    cmd.Parameters.AddWithValue("@storeName", label_Store_Value.Text.ToString());
                    cmd.Parameters.AddWithValue("@quantity", textBox_Quantity.Text.ToString());
                    int r = cmd.ExecuteNonQuery();

                    MessageBox.Show("Record modified successfully");
                    label_Store_Value.ResetText();
                    label_ItemId_Value.ResetText();
                    label_Description_Value.ResetText();
                    label_ItemName_Value.ResetText();
                    label_Price_Value.ResetText();
                    textBox_Quantity.ResetText();
                    textBox_Search.ResetText();

                    con.Close();
                    dataGridView_Stock.DataSource = LoadDataGridViewStock(textBox_Search.Text);
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Select a product from a shop you want to update the stock for.");
                    con.Close();
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    con.Close();
                }
            }
            else
                MessageBox.Show("Select a product from a shop you want to update the stock for.");
        }

        private void Check_Stock_Form_Load(object sender, EventArgs e)
        {
            dataGridView_Stock.DataSource = LoadDataGridViewStock("");
            label_ItemId_Value.Text = "";
            label_Store_Value.Text = "";
        }

        private void button_CancelSearch_Click(object sender, EventArgs e)
        {
            dataGridView_Stock.DataSource = LoadDataGridViewStock("");
            textBox_Search.ResetText();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Stock.DataSource = LoadDataGridViewStock(textBox_Search.Text);
            label_ItemName_Value.ResetText();
            label_Price_Value.ResetText();
            textBox_Quantity.ResetText();
            label_Description_Value.ResetText();
        }

        private DataTable LoadDataGridViewStock(string filter)
        {
            string connectionString = @"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string query = "SELECT \r\n\tpr.ProductId,\r\n\tstore.[Name] AS [Store name],\r\n\tpr.[ProductName] AS [Item name],\r\n\tpc.[Name] AS [Item category],\r\n\tpr.Price,\r\n\tstock.Quantity,\r\n\t pr.Description FROM dbo.Stock stock\r\nJOIN dbo.Product pr ON pr.ProductID = stock.ProductId\r\nJOIN dbo.Store store ON store.StoreID = stock.StoreId\r\nJOIN dbo.ProductCategory pc ON pc.CategoryID = pr.CategoryId";

            if (filter.Length > 0) { query += " WHERE pr.ProductId = @productID"; }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                if (filter.Length > 0)
                {
                    adapter.SelectCommand.Parameters.Add("@productID", SqlDbType.Int).Value = int.Parse(filter);
                }
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return new DataTable();
        }


        private void dataGridView_Stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView_Stock.CurrentRow.Cells;
            if (e.RowIndex >= 0)
            {
                // Create a variable which contains the data from the selected row
                DataGridViewRow row = this.dataGridView_Stock.Rows[e.RowIndex];

                // After selecting a product we load it's data into the visualisers below
                label_ItemId_Value.Text = row.Cells["ProductId"].Value.ToString();
                label_Store_Value.Text = row.Cells["Store name"].Value.ToString();
                label_ItemName_Value.Text = row.Cells["Item name"].Value.ToString();
                label_Category_Value.Text = row.Cells["Item category"].Value.ToString();
                label_Price.Text = row.Cells["Price"].Value.ToString();
                label_Description_Value.Text = row.Cells["Description"].Value.ToString();
                textBox_Quantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Close();
        }
    }
}
