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

namespace listbox
{
    public partial class Modificare_Stergere_Elev : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|elev.mdf;Integrated Security=True;Connect Timeout=30");

        public Modificare_Stergere_Elev()
        {
            InitializeComponent();
            dataGridView1.DataSource = PopulareView();
        }

        private DataTable PopulareView()
        {
            DataTable tbl = new DataTable();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Elevi", con);
            cmd.Fill(tbl);
            dataGridView1.DataSource = tbl;
            con.Close();
            return tbl ;
        }

        private void Buton_Iesire_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Close();
        }

        public void PopulareGridView()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Elevi", con);
            DataTable tbl = new DataTable();
            cmd.Fill(tbl);
            dataGridView1.DataSource = tbl;
            con.Close();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Clase", con);
            SqlDataReader red = cmd1.ExecuteReader();
            while (red.Read())
                comboBox1.Items.Add(red[1].ToString());
            con.Close();
        }

        public void RepopulareGridView()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Elevi", con);
            DataTable tbl = new DataTable();
            cmd.Fill(tbl);
            dataGridView1.DataSource = tbl;
            con.Close();
            ResetareCampuri();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Crearea unei variabile în care sa stocăm înregistrarea selectata
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Completarea spațiilor cu datele elevului selectat
                label15.Text = row.Cells["NrMatricol"].Value.ToString();
                textBox2.Text = row.Cells["Nume"].Value.ToString();
                textBox3.Text = row.Cells["Prenume"].Value.ToString();
                textBox4.Text = row.Cells["Email"].Value.ToString();
                textBox5.Text = row.Cells["Adresa"].Value.ToString();
                comboBox1.SelectedItem = row.Cells["Clasa"].Value.ToString();
                textBox6.Text = row.Cells["DataNasterii"].Value.ToString();
            }
        }

        private void Buton_Stergere_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Elevi WHERE NrMatricol=@nr", con);
            cmd.Parameters.AddWithValue("nr", label15.Text);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                RepopulareGridView();
                MessageBox.Show("Inregistrare stearsa cu succes!");
            }
            else MessageBox.Show("Inregistrarea nu a fost stearsa :(");
        }

        private void Buton_Modificare_Click(object sender, EventArgs e)
        {
            if (label15.Text != "1")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Elevi SET Nume=@nume , Prenume=@prenume, Email=@email , Clasa=@clasa , Adresa=@adresa , DataNasterii=@data WHERE NrMatricol=@nr", con);
                cmd.Parameters.AddWithValue("nr", label15.Text);
                cmd.Parameters.AddWithValue("nume", textBox2.Text);
                cmd.Parameters.AddWithValue("prenume", textBox3.Text);
                cmd.Parameters.AddWithValue("email", textBox4.Text);
                cmd.Parameters.AddWithValue("adresa", textBox5.Text);
                cmd.Parameters.AddWithValue("clasa", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("data", textBox6.Text);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i == 1)
                {
                    RepopulareGridView();
                    MessageBox.Show("Inregistrare actualizata cu succes!");
                }
                else MessageBox.Show("Inregistrarea nu a fost actualizata :(");
            }
        }

        public void ResetareCampuri()
        {
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            comboBox1.ResetText();
            label15.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            con.Open();
            var adp = new SqlDataAdapter("SELECT * FROM Elevi", con);
            var commandBuilder = new SqlCommandBuilder(adp);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = tbl;
            */

            /*
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Elevi", con);
            DataTable tbl = new DataTable();
            cmd.Fill(tbl);
            dataGridView1.DataSource = tbl;
            con.Close();
            */

            DataSet ds = new System.Data.DataSet();
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Elevi", con);
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Modificare_Stergere_Elev_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PopulareView();
        }
    }
}
