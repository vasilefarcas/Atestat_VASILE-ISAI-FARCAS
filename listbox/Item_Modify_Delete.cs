using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LICENTA_VASILE_ISAI_FARCAS
{
    public partial class Item_Modify_Delete : Form
    {
        private SqlConnection con = new SqlConnection(@"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        
        #region Load
        public Item_Modify_Delete()
        {
            InitializeComponent();
        }
        private void Item_Modify_Delete_Load(object sender, EventArgs e)
        {
            dataGridView_Stock.DataSource = LoadDataGridViewStock("");
            dataGridView_Stock.Columns["Description"].Width = 300;
            label_ItemId_Value.ResetText();
            try
            {
                con.Close();
            }
            catch (Exception ex) { }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ProductCategory", con);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
                comboBox_Category.Items.Add(red[4].ToString());
            con.Close();
            red.Dispose();
            cmd.Dispose();
        }
        #endregion

        #region Buttons
        private void button_Modify_Click(object sender, EventArgs e)
        {
            if (textBox_Description.Text.Length > 0 && textBox_ItemName.Text.Length > 0 && textBox_Price.Text.Length > 0 && comboBox_Category.SelectedItem.ToString().Length > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DECLARE @categoryId int\r\n\r\nSELECT @categoryId = CategoryID FROM dbo.ProductCategory WHERE Name = @categoryName\r\n\r\nUPDATE dbo.Product SET ProductName = @productName, CategoryId = @categoryId, Price = @price, [Description] = @description WHERE ProductID = @productId\r\n", con);
                    cmd.Parameters.AddWithValue("@productId", label_ItemId_Value.Text.ToString());
                    cmd.Parameters.AddWithValue("@categoryName", comboBox_Category.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@productName", textBox_ItemName.Text.ToString());
                    cmd.Parameters.AddWithValue("@price", textBox_Price.Text.ToString());
                    cmd.Parameters.AddWithValue("@description", textBox_Description.Text.ToString());
                    int r = cmd.ExecuteNonQuery();

                    MessageBox.Show("Record modified successfully");
                    label_ItemId_Value.ResetText();
                    textBox_Description.ResetText();
                    textBox_ItemName.ResetText();
                    textBox_Price.ResetText();
                    textBox_Search.ResetText();

                    con.Close();
                    dataGridView_Stock.DataSource = LoadDataGridViewStock(textBox_Search.Text);
                    dataGridView_Stock.Columns["Description"].Width = 300;
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Select an item you desire to edit/delete and make sure all fields are correctly filled.");
                    con.Close();
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    con.Close();
                }
            }
            else
                MessageBox.Show("Select an item you desire to edit/delete and make sure all fields are correctly filled.");
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Close();
        }
        #endregion
        
        #region Utils
        private DataTable LoadDataGridViewStock(string filter)
        {
            string connectionString = @"Server=tcp:sqlserverourbusinessclouddb.database.windows.net,1433;Initial Catalog=sql-db-ourbusiness-prod;Persist Security Info=False;User ID=masteradmin;Password=master.adm1n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string query = "SELECT \r\n\tpr.ProductId,\r\n\tpr.[ProductName] AS [Item name],\r\n\tpc.[Name] AS [Item category],\r\n\tpr.Price,\r\n\tpr.Description \r\nFROM dbo.Product pr\r\n\tJOIN dbo.ProductCategory pc ON pc.CategoryID = pr.CategoryId";

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
        #endregion

        #region Search
        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Stock.DataSource = LoadDataGridViewStock(textBox_Search.Text);
            dataGridView_Stock.Columns["Description"].Width = 300;
            label_ItemId_Value.ResetText();
            comboBox_Category.ResetText();
            textBox_Description.ResetText();
            textBox_ItemName.ResetText();
            textBox_Price.ResetText();
        }

        private void button_CancelSearch_Click(object sender, EventArgs e)
        {
            dataGridView_Stock.DataSource = LoadDataGridViewStock("");
            dataGridView_Stock.Columns["Description"].Width = 300;
            label_ItemId_Value.ResetText();
            textBox_Search.ResetText();
            textBox_ItemName.ResetText();
            textBox_Price.ResetText();
            textBox_Description.ResetText();
            comboBox_Category.ResetText();
        }
        #endregion

        #region SpecialEvent
        private void dataGridView_Stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // var value = dataGridView_Stock.SelectedRows.ToString();
            var value = dataGridView_Stock.CurrentRow.Cells;
            if (e.RowIndex >= 0)
            {
                // Crearea unei variabile în care sa stocăm înregistrarea selectata
                DataGridViewRow row = this.dataGridView_Stock.Rows[e.RowIndex];

                // Completarea spațiilor cu datele elevului selectat
                label_ItemId_Value.Text = row.Cells["ProductId"].Value.ToString();
                textBox_ItemName.Text = row.Cells["Item name"].Value.ToString();
                comboBox_Category.SelectedItem = row.Cells["Item category"].Value.ToString();
                textBox_Price.Text = row.Cells["Price"].Value.ToString();
                textBox_Description.Text = row.Cells["Description"].Value.ToString();
            }
        }
        #endregion
    }
}
